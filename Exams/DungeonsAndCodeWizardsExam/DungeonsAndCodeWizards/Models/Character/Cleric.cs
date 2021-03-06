﻿using DungeonsAndCodeWizards;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Enums;
using DungeonsAndCodeWizards.Models.Bag;

public class Cleric : Character, IHealable
{
    private const int BASE_HEALTH = 50;
    private const int BASE_ARMOR = 25;
    private const int ABILITY_POINTS = 40;

    public Cleric(string name, Faction faction)
        : base(name, BASE_HEALTH, BASE_ARMOR, ABILITY_POINTS, new Backpack(), faction)
    {
        
    }

    public override double RestHealMultiplier => 0.5;

    public void Heal(Character character)
    {
        ExceptionTracker.IsAlive(this, character);

        ExceptionTracker.IsHealSameFraction(this, character);

        character.Health += this.AbilityPoints;
    }
}
