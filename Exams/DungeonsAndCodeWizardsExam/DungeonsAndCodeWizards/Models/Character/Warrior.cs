using DungeonsAndCodeWizards;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Enums;
using DungeonsAndCodeWizards.Models.Bag;

public class Warrior : Character, IAttackable
{
    private const int BASE_HEALTH = 100;
    private const int BASE_ARMOR = 50;
    private const int ABILITY_POINTS = 40;

    public Warrior(string name, Faction faction)
        : base(name, BASE_HEALTH, BASE_ARMOR, ABILITY_POINTS, new Satchel(), faction)
    {
    }

    public void Attack(Character character)
    {
        ExceptionTracker.IsAlive(this, character);

        ExceptionTracker.IsSelfAttack(this, character);

        ExceptionTracker.IsFriendlyFire(this, character);

        character.TakeDamage(ABILITY_POINTS);
    }
}
