using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Homework2

{
    internal class Program
    {
        const int MaxElementCount = 1_000_000;
        const int SearchElement = 496_752;
        const int Divider = 777;

        static void Main(string[] args)
        {
            var list = new List<int>();
            var arraylist = new ArrayList();
            var linkedlist = new LinkedList<int>();

            var random = new Random();

            Stopwatch stopwatch = new Stopwatch();

            MeasureCollectionsFilling(list, arraylist, linkedlist, random, stopwatch);

            MeasureCollectionsElementSearch(list, arraylist, linkedlist, stopwatch);

            MeasureCollectionsElementSearchByDivider(list, arraylist, linkedlist, stopwatch);
        }

        private static void MeasureCollectionsElementSearchByDivider(List<int> list, ArrayList arraylist, LinkedList<int> linkedlist, Stopwatch stopwatch)
        {
            int result = 0;

            stopwatch.Restart();

            for (int i = 0; i < list.Count; i++)
            {
                result = list[i];
                if (result % Divider == 0)
                    Console.WriteLine(result);

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск и вывод элементов, которые без остатка делятся на {Divider}, в List : {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            for (int i = 0; i < arraylist.Count; i++)
            {
                result = (int)arraylist[i];
                if (result % Divider == 0)
                    Console.WriteLine(result);

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск и вывод элементов, которые без остатка делятся на {Divider}, в ArrayList : {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            foreach (var number in linkedlist)
            {

                if (number % Divider == 0)
                    Console.WriteLine(number);

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск и вывод элементов, которые без остатка делятся на {Divider}, в LinkedList : {stopwatch.ElapsedMilliseconds} ms");
        }

        private static void MeasureCollectionsElementSearch(List<int> list, ArrayList arraylist, LinkedList<int> linkedlist, Stopwatch stopwatch)
        {
            var result = 0;
            stopwatch.Restart();

            result = list[SearchElement];

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск {SearchElement}-го элемента в List : {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            result = (int)arraylist[SearchElement];

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск числа {SearchElement}-го элемента в ArrayList : {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            result = linkedlist.ElementAt(SearchElement);

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на поиск числа {SearchElement}-го элемента в LinkedList : {stopwatch.ElapsedMilliseconds} ms");
        }

        private static void MeasureCollectionsFilling(List<int> list, ArrayList arraylist, LinkedList<int> linkedlist, Random random, Stopwatch stopwatch)
        {
            stopwatch.Start();

            for (int i = 0; i <= MaxElementCount; i++)
            {
                list.Add(random.Next());

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на добавление чисел в List : {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            for (int i = 0; i <= MaxElementCount; i++)
            {
                arraylist.Add(random.Next());

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на добавление чисел в ArrayList : {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            for (int i = 0; i <= MaxElementCount; i++)
            {

                linkedlist.AddLast(random.Next());

            }

            stopwatch.Stop();

            Console.WriteLine($"Время, затраченное на добавление чисел в LinkedList : {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
