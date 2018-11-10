namespace DungeonsAndCodeWizards.Models.PoisonPotion
{
    public class PoisonPotion : Item.Item
    {
        private const int weight = 5;

        public PoisonPotion() : base(weight)
        {
            
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health -= 20;

            if (character.Health <= 0)
            {
                character.IsAlive = false;
            }
        }
    }
}