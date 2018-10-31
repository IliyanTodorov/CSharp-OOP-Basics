namespace Ferrari
{
    public class Ferrari : Car
    {
        public string model = "488-Spider";

        private string driver;

        public Ferrari(string driver)
        {
            Driver = driver;
        }

        public string Driver
        {
            get { return driver; }
            set { driver = value; }
        }


        public string Brake()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }
    }
}
