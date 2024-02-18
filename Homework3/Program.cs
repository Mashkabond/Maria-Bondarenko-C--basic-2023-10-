using System.Collections;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a * x^2 + b * x + c = 0");
            while (true)
            {
                try
                {
                    var parameters = GetEquationParameters();
                    CalculateRoots(parameters);
                }
                catch (FormatException ex)
                {
                    FormatData(ex.Message, Severity.Error, ex.Data);
                }
                catch (NoRealRootsException ex)
                {
                    FormatData(ex.Message, Severity.Warning, ex.Data);
                }
                catch (Exception ex)
                {
                    FormatData(ex.Message, Severity.Error, ex.Data);
                }
            }
        }

        private static IDictionary<string, int> GetEquationParameters()
        {
            var equationParameters = new Dictionary<string, int>();

            Console.Write("Введите значение a: ");
            var a = int.Parse(Console.ReadLine());
            equationParameters.Add("a", a);

            Console.Write("Введите значение b: ");
            var b = int.Parse(Console.ReadLine());
            equationParameters.Add("b", b);

            Console.Write("Введите значение c: ");
            var c = int.Parse(Console.ReadLine());
            equationParameters.Add("c", c);

            return equationParameters;
        }

        private static void CalculateRoots(IDictionary<string, int> parameters)
        {
            var discriminant = Math.Pow(parameters["b"], 2) - 4 * parameters["a"] * parameters["c"];

            switch (discriminant)
            {
                case < 0:
                    throw new NoRealRootsException("Вещественных значений не найдено");
                case 0:
                {
                    var x = -parameters["b"] / (2 * parameters["a"]);
                    Console.WriteLine($"x = {x}");
                    break;
                }
                default:
                {
                    var x1 = (-parameters["b"] + Math.Sqrt(discriminant)) / (2 * parameters["a"]);
                    var x2 = (-parameters["b"] - Math.Sqrt(discriminant)) / (2 * parameters["a"]);
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                    break;
                }
            }
        }

        private static void FormatData(string message, Severity severity, IDictionary data)
        {
            switch (severity)
            {
                case Severity.Error:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case Severity.Warning:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.WriteLine(message);
            foreach (DictionaryEntry pair in data)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}