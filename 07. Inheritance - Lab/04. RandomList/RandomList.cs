using System;
using System.Collections.Generic;

namespace _04._RandomList
{
    class RandomList : List<string>
    {
        public Random RandomGenerator { get; set; }

        public RandomList()
        {
            RandomGenerator = new Random();
        }

        public string GetRandomElement()
        {
            var index = RandomGenerator.Next(0, Count - 1);
            string resut = this[index];
            RemoveAt(index);

            return resut;
        }
    }
}
