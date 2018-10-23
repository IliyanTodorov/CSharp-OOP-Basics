using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reverseTeam;

    public Team(string name)
    {
        this.firstTeam = new List<Person>();
        this.reverseTeam = new List<Person>();
        this.name = name;
    }

    public List<Person> FirstTeam => firstTeam;

    public List<Person> ReverseTeam => reverseTeam;

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reverseTeam.Add(person);
        }
    }


}

