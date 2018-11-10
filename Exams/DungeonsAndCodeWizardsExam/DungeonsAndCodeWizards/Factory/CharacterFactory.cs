using System;
using DungeonsAndCodeWizards.Enums;

namespace DungeonsAndCodeWizards.Factory
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string faction, string characterType, string name)
        {
            if (!Enum.TryParse(typeof(Faction), faction, out object parsedFaction))
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }

            Faction currentFaction = (Faction)parsedFaction;

            switch (characterType)
            {
                case "Warrior": return new Warrior(name, currentFaction);
                case "Cleric": return new Cleric(name, currentFaction);
                default: throw new ArgumentException($"Invalid character type \"{characterType}\"!");
            }
        }
    }
}