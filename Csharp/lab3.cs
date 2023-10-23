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
       
        public static void p36()
        {
            int n = 0;
            double pi = 0;
            Console.WriteLine("podaj dokladnosc: ");
            double d = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                
                double term = 1.0 / (2 * n + 1);

                if (n % 2 == 0)
                    pi += term;
                else
                    pi -= term;

                n++;

                if (term < d)
                    break;
            }

            pi *= 4; // Mnożenie przez 4, aby uzyskać przybliżoną wartość π

            Console.WriteLine($"Obliczona wartość pi: {pi}");
        }
    }

}
    

