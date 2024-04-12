namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new OtusDictionary();

            dictionary.Add(1, "s1");
            dictionary.Add(2, "s2");
            dictionary.Add(3, "s3");

            Console.WriteLine(dictionary.Get(1));  // s1
            Console.WriteLine(dictionary.Get(-1)); // s1
            Console.WriteLine(dictionary.Get(2));  // s2
            Console.WriteLine(dictionary.Get(3));  // s3

            dictionary.Add(3, "s4");
            Console.WriteLine(dictionary.Get(3)); // s4

            Console.WriteLine(dictionary.Get(0)); // empty
            Console.WriteLine(dictionary.Get(1000)); // empty

            dictionary[10] = "test";
            Console.WriteLine(dictionary[10]); // test

            // ResizeDictionary
            dictionary.Add(20, "s20");
            dictionary.Add(36, "s36");

            dictionary[3] = null; // ArgumentNullException
        }
    }
}