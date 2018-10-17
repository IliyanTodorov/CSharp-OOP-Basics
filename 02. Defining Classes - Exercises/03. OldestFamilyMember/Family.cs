namespace Family
{
    using DefiningClasses;
    using System.Collections.Generic;
    using System.Linq;

    class Family
    {
        private List<Person> family = new List<Person>();

        public void AddMember(Person member)
        {
            family.Add(member);
        }

        public Person GetOldestMember()
        {
            return family.OrderByDescending(x => x.Age).First();
        }
    }
}
