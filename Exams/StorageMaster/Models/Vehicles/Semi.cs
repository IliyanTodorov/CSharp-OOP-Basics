namespace StorageMaster.Models.Vehicles
{
    public class Semi : Vehicle
    {
        private const int CAPACITY = 10;

        public Semi(int capacity) : base(CAPACITY)
        {
        }
    }
}