namespace Program2
{
    internal class Program
    {
        private static readonly List<string> PlanetNames = new()
        {
            "Земля",
            "Лимония",
            "Марс"
        };

        static void Main(string[] args)
        {
            var catalog = new PlanetCatalog();

            foreach (var planetName in PlanetNames)
            {
                PrintPlanetCatalogInfo(planetName, catalog.GetPlanet(planetName));
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