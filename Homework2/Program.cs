using System.Collections;
using System.Diagnostics;

namespace Homework2

{
    internal class Program
    {
        static void Main(string[] args)

        {
            var list = new List<int>();
            var arraylist = new ArrayList();
            var linkedlist = new LinkedList<int>();

            var random = new Random();


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i <= 1000000; i++)
            {
                list.Add(random.Next());

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на добавление чисел в List : {stopwatch.ElapsedMilliseconds} ms");


            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i <= 1000000; i++)
            {
                arraylist.Add(random.Next());

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на добавление чисел в ArrayList : {stopwatch.ElapsedMilliseconds} ms");


            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i <= 1000000; i++)
            {

                linkedlist.AddLast(random.Next());

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на добавление чисел в LinkedList : {stopwatch.ElapsedMilliseconds} ms");


            int result = 0;
            stopwatch = new Stopwatch();
            stopwatch.Start();

            result = list[496752];

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск 496753-го элемента в List : {stopwatch.ElapsedMilliseconds} ms");


            stopwatch = new Stopwatch();
            stopwatch.Start();

            result = (int)arraylist[496752];

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск числа 496753-го элемента в ArrayList : {stopwatch.ElapsedMilliseconds} ms");


            stopwatch = new Stopwatch();
            stopwatch.Start();

            result = linkedlist.ElementAt(496752);

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск числа 496753-го элемента в LinkedList : {stopwatch.ElapsedMilliseconds} ms");


            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < list.Count; i++)
            {
                result = list[i];
                if (result % 777 == 0)
                    Console.WriteLine(result);

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск и вывод элементов, которые без остатка делятся на 777, в List : {stopwatch.ElapsedMilliseconds} ms");


            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < arraylist.Count; i++)
            {
                result = (int)arraylist[i];
                if (result % 777 == 0)
                    Console.WriteLine(result);

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск и вывод элементов, которые без остатка делятся на 777, в ArrayList : {stopwatch.ElapsedMilliseconds} ms");


            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < linkedlist.Count; i++)
            {
                result = linkedlist.ElementAt(i);
                if (result % 777 == 0)
                    Console.WriteLine(result);

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск и вывод элементов, которые без остатка делятся на 777, в LinkedList : {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
