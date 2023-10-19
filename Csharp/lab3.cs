using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class lab3
    {
        public static void p31()
        {
            int suma = 0;
            int ocena = 0;
            int licznik = 0;
            do
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                suma += ocena;
                licznik += 1;
            } while (ocena != -1);
            if (licznik > 0)
            {
                double srednia = suma / (double)licznik;
                Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
            }
            else
            {
                Console.WriteLine("Brak danych do obliczenia średniej");
            }
        }
        public static void p32()
        {
            double lokata = 6000;
            int i = 0;

            while (lokata != 2 * lokata)
            {
                lokata = lokata + (lokata * 0.06);
                i++;
            }
            Console.WriteLine(i);
        }
        public static void p33()
        {
            Random r = new Random();
            int n = r.Next(1, 50);
            int liczba;
            int i = 0;
            do
            {
                liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba > n)
                {
                    Console.WriteLine("za duzo");
                }
                else { Console.WriteLine("za malo"); }
                i++;
            } while (liczba != n);

            Console.WriteLine("brawo zgadles za " + i + " razem");

        }
        public static void p34()
        {
            double liczba = 50;
            double liczba1 = 50;
            int i = 0;
            while (liczba % 2 != 1)
            {
                liczba = liczba / 2;
                i++;
            }
            if ((Math.Pow(2, i) != liczba1))
            {
                Console.WriteLine("to nie jesst potega 2");
            }
            else { Console.WriteLine(i); }

        }
        public static void p35()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

        }
        public static void p36()

        {
            double suma = 1;
            double d = Convert.ToDouble(Console.ReadLine());
            int n = 1;
            double suma1 = 0;
            while ((suma - suma1) > d) ;
            {
                suma1 = suma;
                suma = suma + (1 / (n));
                
                n = n + 2;
            } 
            Console.WriteLine("liczpa pi wynosi: " + (suma * 4));

        }
    }
}
