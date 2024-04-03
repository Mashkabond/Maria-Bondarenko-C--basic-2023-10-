namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var venus1 = new
            {
                Name = "Венера",
                NumberFromSun = 2,
                EquatorLength = 38025,
                PreviousPlanet = (object)null,
            };

            var earth = new
            {
                Name = "Земля",
                NumberFromSun = 3,
                EquatorLength = 40075,
                PreviousPlanet = (object)venus1,
            };

            var mars = new
            {
                Name = "Марс",
                NumberFromSun = 4,
                EquatorLength = 21344,
                PreviousPlanet = (object)earth,
            };

            var venus2 = new
            {
                Name = "Венера",
                NumberFromSun = 2,
                EquatorLength = 38025,
                PreviousPlanet = (object)mars,
            };

            Console.WriteLine($"{venus1}. Эквивалентна Венере = {venus1.Equals(venus1)}");
            Console.WriteLine($"{earth}. Эквивалентна Венере = {earth.Equals(venus1)}");
            Console.WriteLine($"{mars}. Эквивалентна Венере = {mars.Equals(venus1)}");
            Console.WriteLine($"{venus2}. Эквивалентна Венере = {venus2.Equals(venus1)}");
        }
    }
}