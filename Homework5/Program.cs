namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRobot robot = new Quadcopter();

            Console.WriteLine(robot.GetInfo());
            Console.WriteLine(string.Join(", ", robot.GetComponents().ToArray()));
            Console.WriteLine(robot.GetRobotType());

            IChargeable chargeable = (IChargeable)robot;
            Console.WriteLine(chargeable.GetInfo());
            chargeable.Charge();

            IFlyingRobot flyingRobot = (IFlyingRobot)robot;
            Console.WriteLine(flyingRobot.GetRobotType());
        }
    }
}