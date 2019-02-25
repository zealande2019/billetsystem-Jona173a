using System;

namespace BilletLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Nummerplade = Convert.ToString(Console.ReadLine());
            //if (Nummerplade.Length < 7)
            //{
            //    throw new System.Exception("Du har indtastet for mange cifre eller tal!");
            //}
            //else
            //{
            //    Console.WriteLine("Nummerpladen er: " + Nummerplade);
            //}


            Bil bil1 = new Bil();
            MC mc1 = new MC();


            DateTime dato = new DateTime(2019, 2, 20);
            Console.WriteLine();
            Console.WriteLine($"Dato: {dato}");
            //Console.WriteLine("Indtast nummerplade: " + Nummerplade);
            Console.WriteLine(bil1.PrintInfo());
            Console.WriteLine(mc1.PrintInfo());
            Console.ReadLine();
        }
    }
}
