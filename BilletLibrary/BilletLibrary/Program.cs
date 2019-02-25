using System;

namespace BilletLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil1 = new Bil();
            MC mc1 = new MC();

            DateTime dato = new DateTime(2019, 2, 20);
            Console.WriteLine();
            Console.WriteLine($"Dato: {dato}");

            bil1.BilNummerplade = "sfsf";
            Console.WriteLine(bil1.BilNummerplade);

            Console.WriteLine(bil1.PrintInfo());
            Console.WriteLine(mc1.PrintInfo());

            Console.WriteLine(bil1.BilNummerplade);

            Console.ReadLine();
        }
    }
}
