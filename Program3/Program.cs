namespace Program3
{
    internal class Program
    {
        private static readonly List<string> PlanetNames = new()
        {
            "Земля",
            "Лимония",
            "Марс"
        };

        private static int _counter;

        static void Main(string[] args)
        {
            var catalog = new PlanetCatalog();

            foreach (var planetName in PlanetNames)
            {
                PrintPlanetCatalogInfo(planetName, catalog.GetPlanet(planetName,
                    _ => 
                    {
                        _counter++;
                        return _counter % 3 == 0 ? "Вы спрашиваете слишком часто" : null;
                    }));
            }

            foreach (var planetName in PlanetNames)
            {
                PrintPlanetCatalogInfo(planetName, catalog.GetPlanet(planetName,
                    name =>
                    {
                        return name.Equals("Лимония") ? "Это запретная планета" : null;
                    }));
            }
        }

        static void PrintPlanetCatalogInfo(string planetName, (int? numberFromSun, int? equatorLength, string? errorMessage) planetCatalogInfo)
        {
            if (planetCatalogInfo.errorMessage == null)
            {
                Console.WriteLine($"Name: {planetName}, NumberFromSun: {planetCatalogInfo.numberFromSun}, EquatorLength: {planetCatalogInfo.equatorLength}");
            }
            else
            {
                Console.WriteLine(planetCatalogInfo.errorMessage);
            }
        }
    }
}