namespace DungeonsAndCodeWizards.Models.ArmorRepairKit
{
    public class ArmorRepairKit : Item.Item
    {
        private const int weight = 10;

        public ArmorRepairKit() : base(weight)
        {
            
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Armor = character.BaseArmor;
        }
    }
}