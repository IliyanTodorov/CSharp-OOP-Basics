namespace StorageMaster.Models.Products
{
    public class HardDrive : Product
    {
        private const double WEIGHT = 1.0;

        public HardDrive(double price)
            : base(price, WEIGHT)
        {
        }
    }
}