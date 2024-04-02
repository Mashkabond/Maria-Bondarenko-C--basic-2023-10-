namespace Homework5
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private readonly List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };

        string IRobot.GetInfo()
        {
            return "I am Quadcopter";
        }

        string IChargeable.GetInfo()
        {
            return "I am chargeable Quadcopter";
        }

        public List<string> GetComponents()
        {
            return _components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
    }
}
