namespace Program3
{
    public class Planet
    {
        public string Name { get; }
        public int NumberFromSun { get; }
        public int EquatorLength { get; }
        public Planet? PreviousPlanet { get; }

        public Planet(string name, int numberFromSun, int equatorLength, Planet? previousPlanet)
        {
            Name = name;
            NumberFromSun = numberFromSun;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
    }
}
