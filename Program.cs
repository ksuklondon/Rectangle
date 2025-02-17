using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostokat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat mojProstokat = new Prostokat(4, 4);

            Console.WriteLine($"Szerokość: {mojProstokat.Szerokosc} cm");
            Console.WriteLine($"Wysokość: {mojProstokat.Wysokosc} cm");

            Console.WriteLine($"Pole: {mojProstokat.ObliczPole():0.00} cm²");
            Console.WriteLine($"Obwód: {mojProstokat.ObliczObwod():0.00} cm");

            mojProstokat.Rysuj();
        }
    }
}
