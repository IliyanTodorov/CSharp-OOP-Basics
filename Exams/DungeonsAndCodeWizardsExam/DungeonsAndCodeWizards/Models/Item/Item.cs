using System;

namespace DungeonsAndCodeWizards.Models.Item
{
    public abstract class Item
    {
        public int Weight { get; protected set; }

        public Item(int weight)
        {
            this.Weight = weight;
        }

        public virtual void AffectCharacter(Character character)
        {
            ExceptionTracker.IsAlive(character);
        }
    }
}