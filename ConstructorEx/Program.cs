using System;

namespace ConstructorEx
{
    class Program
    {
        static Random rng = new Random();
        static void Main()
        {
            Console.WriteLine("Hello World!");
            MakeAtom();
            Console.WriteLine("More code.");
            MakeAtom();
            Console.WriteLine("Even more code.");
            Console.WriteLine();
            GC.Collect();
        }

        private static void MakeAtom()
        {
            _ = new Atom(rng.Next(16), rng.Next(10));
        }
    }
}
