namespace People
{
    using DefiningClasses;
    using System.Collections.Generic;
    using System.Linq;

    class People
    {
        private List<Person> people = new List<Person>();

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public List<Person> GetPeopleMoreThan30YearsOld()
        {
            return people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }
    }
}
