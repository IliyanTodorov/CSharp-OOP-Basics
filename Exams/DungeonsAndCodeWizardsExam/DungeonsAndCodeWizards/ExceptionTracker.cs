using System;
using System.Collections.Generic;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Models.Item;

namespace DungeonsAndCodeWizards
{
    public static class ExceptionTracker
    {
        public static void IsNameCorrect(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }
        }

        public static void IsAlive(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public static void IsAlive(Character first, Character second)
        {
            if (!first.IsAlive || !second.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public static void IsSelfAttack(Character first, Character second)
        {
            if (first.Equals(second))
            {
                throw new InvalidOperationException("Cannot attack self!");
            }
        }

        public static void IsFriendlyFire(Character first, Character second)
        {
            if (first.Faction == second.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {first.Faction} faction!");
            }
        }

        public static void IsHealSameFraction(Character first, Character second)
        {
            if (first.Faction != second.Faction)
            {
                throw new InvalidOperationException($"Cannot heal enemy character!");
            }
        }

        public static void DoesCharacterExist(Character character, string name)
        {
            if (character == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }
        }

        public static void DoesItemExist(Item item)
        {
            if (item == null)
            {
                throw new ArgumentException($"No items left in pool!");
            }
        }

        public static void AttackableCharacter(Character character)
        {
            if (!(character is IAttackable))
            {
                throw new ArgumentException($"{character.Name} cannot attack!");
            }
        }
    }
}