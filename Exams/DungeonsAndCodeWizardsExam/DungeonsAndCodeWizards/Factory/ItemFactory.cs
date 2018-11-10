using System;
using DungeonsAndCodeWizards.Models.ArmorRepairKit;
using DungeonsAndCodeWizards.Models.HealthPotion;
using DungeonsAndCodeWizards.Models.Item;
using DungeonsAndCodeWizards.Models.PoisonPotion;

namespace DungeonsAndCodeWizards.Factory
{
    public class ItemFactory
    {
        public Item CreateItem(string name)
        {
            switch (name)
            {
                case "ArmorRepairKit": return new ArmorRepairKit();
                case "HealthPotion": return new HealthPotion();
                case "PoisonPotion": return new PoisonPotion();
                default: throw new ArgumentException($"Invalid item \"{name}\"!");
            }
        }

        public Item ItemExist(string name)
        {
            switch (name)
            {
                case "ArmorRepairKit": return new ArmorRepairKit();
                case "HealthPotion": return new HealthPotion();
                case "PoisonPotion": return new PoisonPotion();
                default: throw new ArgumentException($"No item with name {name} in bag!");
            }
        }
    }
}