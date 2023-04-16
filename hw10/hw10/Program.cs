using Homework10;
using System.Linq;

namespace Homework10
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person("John", "Wick", 58),
                new Person("Jecki", "Chan", 70),
                new Person("John", "Smith", 25),
                new Person("Bill", "Gates", 63),
                new Person("Marilyn", "Monroe", 35),
                new Person("Albert", "Einstein", 70),
                new Person("Walt", "Disney", 65),
                new Person("Pablo", "Picasso", 35)
            };

            
                
            MyPeopleList peopleList = new MyPeopleList(people);

            

            Person[] pepleOver40 = peopleList.Where((person) => person.Age > 40).OrderBy((person) => person.Surname).ToArray();

            Adult[] adultPersons = pepleOver40.Select((person) => new Adult(person.Name, person.Surname, person.Age)).ToArray();

            Boolean isJhonHere = adultPersons.Any((person) => person.Name == "John");

            Person oldest = peopleList.OrderByDescending((person) => person.Age).ToArray().FirstOrDefault();

            int averageBirthYear = peopleList.Aggregate(0, (prev, curr) => prev + curr.BirthYear) / peopleList.Count();

           Console.WriteLine(averageBirthYear);

        }
    }
}
