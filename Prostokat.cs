using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostokat
{
    public class Prostokat
    {
        // Wlasciwosci
        public double szerokosc;
        public double wysokosc;

        // Konstruktor parametryczny
        public Prostokat(double szerokosc, double wysokosc)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
        }

        public double Szerokosc
        {
            get { return szerokosc; }
            set { if (value > 0) szerokosc = value; }
        }

        public double Wysokosc
        {
            get { return wysokosc; }
            set { if (value > 0) wysokosc = value; }
        }


        // Metody
        public double ObliczPole()
        {
            return szerokosc * wysokosc;
        }

        public double ObliczObwod()
        {
            return 2 * (szerokosc + wysokosc);
        }

        public void Rysuj()
        {
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
