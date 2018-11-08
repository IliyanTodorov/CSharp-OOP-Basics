namespace StorageMaster.Models.Vehicles
{
    public class Van : Vehicle
    {
        private const int CAPACITY = 2;

        public Van(int capacity) : base(CAPACITY)
        {
        }
    }
}