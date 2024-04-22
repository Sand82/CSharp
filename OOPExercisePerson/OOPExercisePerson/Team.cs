using System.Collections.ObjectModel;

namespace OOPExercisePerson
{
    public class Team
    {
        private readonly List<Person> firstTeam = new();

        private readonly List<Person> reserveTeam = new();

        public Team(string name)
        {
            this.Name = name; 
            FirstTeamCount = firstTeam.Count;
            ReserveTeamCount = reserveTeam.Count;
        }

        public string Name { get; init; }

        public int FirstTeamCount { get; private set; }

        public int ReserveTeamCount { get; private set; }

        public void Add(Person person) 
        {
            if (person.Age >= 40)
            {
                reserveTeam.Add(person);
                ReserveTeamCount++;
            }
            else
            {
                firstTeam.Add(person);
                FirstTeamCount++;
            }
        }
    }
}
