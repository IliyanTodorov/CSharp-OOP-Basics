using DungeonsAndCodeWizards;
using DungeonsAndCodeWizards.Factory;
using DungeonsAndCodeWizards.Models.Item;
using System.Collections.Generic;
using System.Linq;

public class DungeonMaster
{
    private IList<Character> party;
    private IList<Item> pool;
    private int lastSurvivorRounds;

    public DungeonMaster()
    {
        this.party = new List<Character>();
        this.pool = new List<Item>();
        this.lastSurvivorRounds = 0;
    }

    public string JoinParty(string[] args)
    {
        var faction = args[0];
        var characterType = args[1];
        var name = args[2];

        Character character = new CharacterFactory().CreateCharacter(faction, characterType, name);
        party.Add(character);

        return $"{character.Name} joined the party!";
    }

    public string AddItemToPool(string[] args)
    {
        string itemName = args[0];

        Item item = new ItemFactory().CreateItem(itemName);
        pool.Add(item);

        return $"{itemName} added to pool.";
    }

    public string PickUpItem(string[] args)
    {
        var characterName = args[0];

        var character = party.FirstOrDefault(c => c.Name == characterName);
        ExceptionTracker.DoesCharacterExist(character, characterName);

        var item = pool.LastOrDefault();
        ExceptionTracker.DoesItemExist(item);

        pool.Remove(item);

        return $"{characterName} picked up {item.GetType().Name}!";
    }

    public string UseItem(string[] args)
    {
        var characterName = args[0];
        var itemName = args[1];

        var character = party.FirstOrDefault(c => c.Name == characterName);
        ExceptionTracker.DoesCharacterExist(character, characterName);

        var item = character.Bag.GetItem(itemName);
        character.UseItem(item);

        return $"{character.Name} used {itemName}.";
    }

    public string UseItemOn(string[] args)
    {
        var giverName = args[0];
        var receiverName = args[1];
        var itemName = args[2];

        var giverCharacter = party.FirstOrDefault(c => c.Name == giverName);
        ExceptionTracker.DoesCharacterExist(giverCharacter, giverName);

        var receiverCharacter = party.FirstOrDefault(c => c.Name == receiverName);
        ExceptionTracker.DoesCharacterExist(receiverCharacter, receiverName);

        var item = giverCharacter.Bag.GetItem(itemName);
        giverCharacter.UseItemOn(item, receiverCharacter);

        return $"{giverName} used {itemName} on {receiverName}.";
    }

    public string GiveCharacterItem(string[] args)
    {
        var giverName = args[0];
        var receiverName = args[1];
        var itemName = args[2];

        var giverCharacter = party.FirstOrDefault(c => c.Name == giverName);
        ExceptionTracker.DoesCharacterExist(giverCharacter, giverName);

        var receiverCharacter = party.FirstOrDefault(c => c.Name == receiverName);
        ExceptionTracker.DoesCharacterExist(receiverCharacter, receiverName);

        var item = giverCharacter.Bag.GetItem(itemName);
        giverCharacter.GiveCharacterItem(item, receiverCharacter);

        return $"{giverName} gave {receiverName} {itemName}.";
    }

    public string GetStats()
    {
        return string.Join("\n", party.OrderByDescending(c => c.IsAlive).ThenByDescending(c => c.Health));
    }

    public string Attack(string[] args)
    {
        var attackerName = args[0];
        var receiverName = args[1];

        var attackerCharacter = party.FirstOrDefault(c => c.Name == attackerName);
        ExceptionTracker.DoesCharacterExist(attackerCharacter, attackerName);

        var receiverCharacter = party.FirstOrDefault(c => c.Name == receiverName);
        ExceptionTracker.DoesCharacterExist(receiverCharacter, receiverName);

        ExceptionTracker.AttackableCharacter(attackerCharacter);

        ((Warrior)attackerCharacter).Attack(receiverCharacter);

        var output = $"{attackerName} attacks {receiverName} for {attackerCharacter.AbilityPoints} hit points!" +
                     $" {receiverName} has {receiverCharacter.Health}/{receiverCharacter.BaseHealth} HP " +
                     $"and {receiverCharacter.Armor}/{receiverCharacter.BaseArmor} AP left!";

        if (!receiverCharacter.IsAlive)
        {
            output += $"\n{receiverCharacter.Name} is dead!";
        }

        return output;
    }

    public string Heal(string[] args)
    {
        string healerName = args[0];
        string healingReceiverName = args[1];

        var healer = party.FirstOrDefault(c => c.Name == healerName);
        var receiver = party.FirstOrDefault(c => c.Name == healingReceiverName);

        ExceptionTracker.DoesCharacterExist(healer, healerName);
        ExceptionTracker.DoesCharacterExist(receiver, healingReceiverName);

        ((Cleric)healer).Heal(receiver);

        return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}!" +
               $"{receiver.Name} has {receiver.Health} health now!";
    }

    public string EndTurn(string[] args)
    {
        var output = new List<string>();
        foreach (var character in party)
        {
            if (character.IsAlive)
            {
                var healthBeforeRest = character.Health;
                character.Rest();
                output.Add($"{character.Name} rests ({healthBeforeRest} => {character.Health})");
            }
        }
        if (party.Count <= 1)
        {
            lastSurvivorRounds++;
        }

        return string.Join("\n", output);
    }

    public bool IsGameOver()
    {
        return lastSurvivorRounds > 1;
    }
}
