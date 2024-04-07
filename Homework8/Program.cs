namespace Homework8
{
    internal class Program
    {
        private static EmployeeTree _tree = new EmployeeTree();
        private static int _userEmployeeSalaryInput;
        private static int _userActionInput;

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            while (true) 
            {
                if (_userActionInput == 0)
                {
                    _tree.Clear();
                    StartUserEmployeesInput();
                    _tree.Traversal();
                    Console.WriteLine();
                }
                StartUserEmployeeSalaryInput();
                var employeeName = _tree.FindEmployeeNameBySalary(_userEmployeeSalaryInput);
                if (employeeName != null)
                {
                    Console.WriteLine($"Найден сотрудник с такой зарплатой - {employeeName}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Такой сотрудник не найден");
                    Console.WriteLine();
                }
                StartUserActionInput();
            }
        }

        static void StartUserEmployeesInput() 
        {
            while (true)
            {
                Console.WriteLine("Введите имя сотрудника:");
                var employeeName = Console.ReadLine() ?? string.Empty;
                if (employeeName == string.Empty) break;

                Console.WriteLine("Введите ЗП сотрудника:");
                int employeeSalary;
                while (!int.TryParse(Console.ReadLine(), out employeeSalary))
                {
                    Console.WriteLine("Необходимо ввести числовое значение. Повторите ввод:");
                }
                _tree.Add(employeeName, employeeSalary);
                Console.WriteLine();
            }
        }

        static void StartUserEmployeeSalaryInput()
        {
            Console.WriteLine("Введите интересующую зарплату:");
            while (!int.TryParse(Console.ReadLine(), out _userEmployeeSalaryInput))
            {
                Console.WriteLine("Необходимо ввести числовое значение. Повторите ввод:");
            }
        }

        static void StartUserActionInput()
        {
            while (true)
            {
                Console.WriteLine("Выберите следующее действие:");
                Console.WriteLine("0: Начать сначала");
                Console.WriteLine("1: Искать сотрудника по зарплате");

                var userActionInput = Console.ReadLine();
                if (userActionInput == "0" || userActionInput == "1")
                {
                    _userActionInput = int.Parse(userActionInput);
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}