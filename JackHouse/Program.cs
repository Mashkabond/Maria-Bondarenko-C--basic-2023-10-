using System.Collections.Immutable;

namespace JackHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var poem = ImmutableList<string>.Empty;

            var p1 = new Part1();
            p1.Addpart(poem);

            var p2 = new Part2();
            p2.Addpart(p1.Poem);

            var p3 = new Part3();
            p3.Addpart(p2.Poem);

            var p4 = new Part4();
            p4.Addpart(p3.Poem);

            var p5 = new Part5();
            p5.Addpart(p4.Poem);

            var p6 = new Part6();
            p6.Addpart(p5.Poem);

            var p7 = new Part7();
            p7.Addpart(p6.Poem);

            var p8 = new Part8();
            p8.Addpart(p7.Poem);

            var p9 = new Part9();
            p9.Addpart(p8.Poem);

            Console.WriteLine("p1:");
            p1.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p2:");
            p2.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p3:");
            p3.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p4:");
            p4.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p5:");
            p5.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p6:");
            p6.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p7:");
            p7.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p8:");
            p8.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("p9:");
            p9.Poem.ForEach(Console.WriteLine);
            Console.WriteLine();
        }

        class Part1
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("Вот дом,\nКоторый построил Джек.");
            }
        }

        class Part2
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("А это пшеница,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }

        class Part3
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("А это веселая птица-синица,\nКоторая часто ворует пшеницу,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }

        class Part4
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("Вот кот,\nКоторый пугает и ловит синицу,\nКоторая часто ворует пшеницу,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }

        class Part5
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("Вот пес без хвоста,\nКоторый за шиворот треплет кота,\nКоторый пугает и ловит синицу,\nКоторая часто ворует пшеницу,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }

        class Part6
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("А это корова безрогая,\nЛягнувшая старого пса без хвоста,\nКоторый за шиворот треплет кота,\nКоторый пугает и ловит синицу,\nКоторая часто ворует пшеницу,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }

        class Part7
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("А это старушка, седая и строгая,\nКоторая доит корову безрогую,\nЛягнувшую старого пса без хвоста,\nКоторый за шиворот треплет кота,\nКоторый пугает и ловит синицу,\nКоторая часто ворует пшеницу,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }

        class Part8
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("А это ленивый и толстый пастух,\nКоторый бранится с коровницей строгою,\nКоторая доит корову безрогую,\nЛягнувшую старого пса без хвоста,\nКоторый за шиворот треплет кота,\nКоторый пугает и ловит синицу,\nКоторая часто ворует пшеницу,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }

        class Part9
        {
            public ImmutableList<string> Poem { get; private set; }

            public void Addpart(ImmutableList<string> poem)
            {
                Poem = poem.Add("Вот два петуха,\nКоторые будят того пастуха,\nКоторый бранится с коровницей строгою,\nКоторая доит корову безрогую,\nЛягнувшую старого пса без хвоста,\nКоторый за шиворот треплет кота,\nКоторый пугает и ловит синицу,\nКоторая часто ворует пшеницу,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            }
        }
    }
}