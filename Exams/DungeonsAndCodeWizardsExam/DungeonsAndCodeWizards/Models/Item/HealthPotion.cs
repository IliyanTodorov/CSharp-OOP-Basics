namespace DungeonsAndCodeWizards.Models.HealthPotion
{
    public class HealthPotion : Item.Item
    {
        private const int weight = 5;

        public HealthPotion() : base(weight)
        {
            
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health += 20;
        }
    }
}