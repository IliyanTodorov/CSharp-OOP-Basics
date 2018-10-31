using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            IsValidNumber(number);

            return "Calling... " + number;
        }

        public string Browse(string website)
        {
            IsValidWebsite(website);

            return "Browsing: " + website + "!";
        }

        private void IsValidWebsite(string website)
        {
            bool containsNum = website.Any(char.IsNumber);

            if (containsNum)
            {
                throw new ArgumentException("Invalid URL!");
            }
        }

        private void IsValidNumber(string number)
        {
            bool allNums = number.All(char.IsNumber);

            if (!allNums)
            {
                throw new ArgumentException("Invalid number!");
            }
        }
    }
}
