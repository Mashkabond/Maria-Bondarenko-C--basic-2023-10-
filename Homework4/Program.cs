namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

            var deleted = s.Pop();
            // Извлекли верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлекли верхний элемент '{deleted}' Size = {s.Size}");
            
            s.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");

            var s1 = new Stack("a", "b", "c");
            s1.Merge(new Stack("1", "2", "3"));
            // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний
            // size = 6, Top = '1'
            Console.WriteLine($"size = {s1.Size}, Top = '{s1.Top}'");

            var s2 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            // в стеке s теперь элементы - "c", "b", "a" "3", "2", "1", "В", "Б", "А" <- верхний
            // size = 9, Top = 'А'
            Console.WriteLine($"size = {s2.Size}, Top = '{s2.Top}'");

            s.Pop();
        }
    }
}
