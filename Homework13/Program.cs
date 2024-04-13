namespace Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(string.Join(", ", numbers.Top(30).ToList()));

            var people = new List<Person>()
            {
                new("Мария", 27),
                new("Анна", 30),
                new("Алексей", 26),
                new("Екатерина", 35)
            };
            Console.WriteLine(string.Join("\n", people.Top(30, person => person.Age).ToList()));
        }

        private class Person
        {
            public string Name { get; }
            public int Age { get; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"Имя: {Name}, Возраст: {Age}";
            }
        }
    }
}