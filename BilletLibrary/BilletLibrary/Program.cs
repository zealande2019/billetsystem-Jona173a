using System;

namespace BilletLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil1 = new Bil();
            MC mc1 = new MC();

            Console.WriteLine(bil1.PrintInfo());
            Console.WriteLine(mc1.PrintInfo());

            Console.ReadLine();
        }
    }
}
