using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class lab2
    {
        static void p21()
        {
            int suma = 0;
            int ocena;
            int liczba = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                if (ocena >= 3)
                {
                    suma += ocena;
                    liczba++;
                }
                else { continue; }
            }
            double srednia = suma / liczba;
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
        }
        static void p22()
        {
            double lokata = 0;
            int lata = 0;
            Console.WriteLine("Podaj kwote na lokacie: ");
            lokata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj na ile lat jest lokata: ");
            lata = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= lata; i++)
            {
                lokata = lokata + lokata * 0.06;
            }
            Console.WriteLine("lokata po naliczeniu odsetek wynosi: {0:F2}", lokata);
        }
        static void p23()
        {
            double max = Convert.ToDouble(Console.ReadLine());
            double min = max;

            for (int i = 2; i <= 5; i++)
            {
                double liczba1 = Convert.ToDouble(Console.ReadLine());
                if (liczba1 > max)
                {
                    max = liczba1;
                }
                else if (liczba1 < min) { min = liczba1; }


            }
            Console.WriteLine("Najwieksza liczba to " + max + "a najmniejsza to: " + min);
        }
        static void p24()
        {
            int k = 120;
            double S = 1.8;
            Console.WriteLine("Podaj dlugosc skoku: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double pd = 60 + (d - k) * S;
            Console.WriteLine("Podaj 5 ocen: ");
            int[] punkty = new int[5];
            for (int j = 0; j <= 4; j++)
            {
                punkty[j] = Convert.ToInt32(Console.ReadLine());
                if (punkty[j] > 20 || punkty[j] < 0)
                {
                    Console.WriteLine("niepoprawna ilosc punktow");
                    break;
                }
            }
            int max = 0;
            int min = 20;
            int oceny = 0;
            for (int i = 0; i <= 4; i++)
            {
                if (punkty[i] > max) { max = punkty[i]; }
                if (punkty[i] < min) { min = punkty[i]; }
                oceny = oceny + punkty[i];
            }
            oceny = oceny - max - min;
            Console.WriteLine("wynik wynosi: " + (pd + oceny));

        }




        static int p25(int n)
        {

            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * (i);
            }
            return wynik;
        }
        static void p26()
        {
            int liczba = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i = 2; i < Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    Console.WriteLine("to nie jest liczba pierwsza");
                    k = k + 1;
                    break;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("to jest l pierwsza");
            }

        }
        static void p27()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {

                        k = k + 1;
                        continue;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine(i + " to jest l. pierwsza");
                }
                k = 0;
            }
        }
        static void p28()
        {
            int n = 5;
            int k = 3;

            double wynik = (p25(n) / (p25(k) * p25(n - k)));
            Console.WriteLine(wynik);
        }
    }
}
