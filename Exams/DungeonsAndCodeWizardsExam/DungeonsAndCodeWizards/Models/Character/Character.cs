using DungeonsAndCodeWizards;
using DungeonsAndCodeWizards.Enums;
using DungeonsAndCodeWizards.Models.Bag;
using DungeonsAndCodeWizards.Models.Item;


public abstract class Character
{
    private string name;
    private double baseHealth;
    private double baseArmor;
    private double abilityPoints;
    private Faction faction;
    private double health;
    private double armor;
    private Bag bag;

    public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
    {
        this.Name = name;
        this.BaseHealth = health;
        this.Health = health;
        this.BaseArmor = armor;
        this.Armor = armor;
        this.IsAlive = true;
        this.AbilityPoints = abilityPoints;
        this.Bag = bag;
        this.Faction = faction;
    }

    public string Name
    {
        get => name;
        set
        {
            ExceptionTracker.IsNameCorrect(value);
            name = value;
        }
    }

    public double BaseHealth
    {
        get { return this.baseHealth; }
        set { this.baseHealth = value; }
    }

    public double Health
    {
        get { return this.Health; }
        set
        {
            if (value <= 0)
            {
                this.health = 0;
                this.IsAlive = false;
            }
            else if (value > this.BaseHealth)
            {
                this.health = this.BaseHealth;
            }
            else
            {
                this.health = value;
            }
        }
    }

    public double BaseArmor
    {
        get { return this.baseArmor; }
        set { this.baseArmor = value; }
    }

    public double Armor
    {
        get { return this.armor; }
        set
        {
            if (value <= 0)
            {
                this.armor = 0;
                this.IsAlive = false;
            }
            else if (value >= this.BaseArmor)
            {
                this.armor = this.BaseArmor;
            }
            else
            {
                this.health = value;
            }
        }
    }

    public bool IsAlive { get; set; }

    public double AbilityPoints { get => abilityPoints; set => abilityPoints = value; }

    public Bag Bag { get => bag; set => bag = value; }

    public Faction Faction
    {
        get { return this.faction; }
        set { this.faction = value; }
    }

    public virtual double RestHealMultiplier => 0.2;

    public void TakeDamage(double hitPoints)
    {
        ExceptionTracker.IsAlive(this);

        if (Armor < hitPoints)
        {
            Armor -= hitPoints;
            hitPoints -= this.Armor;

            Health -= hitPoints;

            if (Health <= 0)
            {
                IsAlive = false;
            }
        }
        else
        {
            Armor -= hitPoints;
        }
    
    }

    public void Rest()
    {
        ExceptionTracker.IsAlive(this);

        Health += BaseHealth * RestHealMultiplier;
    }

    public void UseItem(Item item)
    {
        ExceptionTracker.IsAlive(this);

        item.AffectCharacter(this);
    }

    public void UseItemOn(Item item, Character character)
    {
        ExceptionTracker.IsAlive(this, character);

        item.AffectCharacter(character);
    }

    public void GiveCharacterItem(Item item, Character character)
    {
        ExceptionTracker.IsAlive(this, character);

        character.Bag.AddItem(item);
    }

    public void ReceiveItem(Item item)
    {
        ExceptionTracker.IsAlive(this);

        this.Bag.AddItem(item);
    }
}