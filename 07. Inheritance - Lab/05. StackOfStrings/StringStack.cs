using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._StackOfStrings
{
    class StringStack : List<string>
    {
        public void Push(string element)
        {
            Add(element);
        }

        public string Pop()
        {
            string element = GetLastElement();
            RemoveAt(Count - 1);

            return element;
        }

        public string Peek()
        {
            return GetLastElement();
        }

        public bool IsEmpty()
        {
            return Count < 1;
        }

        private string GetLastElement()
        {
            if (IsEmpty())
            {
                throw new ArgumentOutOfRangeException("The Stack is empty");
            }

            return this.Last();
        }
    }
}
