namespace Program3
{
    public class PlanetCatalog
    {
        private List<Planet> _planets = new List<Planet>();

        public PlanetCatalog(params Planet[] planet)
        {
            _planets.Add(new Planet("Венера", 2, 38025, null));
            _planets.Add(new Planet("Земля", 3, 40075, _planets.Last()));
            _planets.Add(new Planet("Марс", 4, 21344, _planets.Last()));
            _planets.AddRange(planet);
        }

        public (int? numberFromSun, int? equatorLength, string? errorMessage) GetPlanet(string name,
            Func<string, string?> planetValidator)
        {
            var errorMessage = planetValidator(name);
            if (errorMessage != null)
            {
                return (null, null, errorMessage);
            }

            var planet = _planets.FirstOrDefault(planet => planet.Name.Equals(name));
            if (planet == null) 
            {
                return (null, null, "Не удалось найти планету");
            } else
            {
                return (planet.NumberFromSun, planet.EquatorLength, null);
            }
        }
    }
}
