﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            p34();
        }

        static void cw1()
        {
            Console.WriteLine("Wprowadz promien: ");
            double promien = double.Parse(Console.ReadLine());
            Console.WriteLine("Pole wynosi: " + Math.PI * Math.Pow(promien, 2));


        }

        static void cw2()
        {
            Console.WriteLine("wprowadz pierwszy bok: ");
            double bok1 = double.Parse(Console.ReadLine());
            Console.WriteLine("wprowadz drugi bok: ");
            double bok2 = double.Parse(Console.ReadLine());
            if (bok1 == bok2)
            {
                Console.WriteLine("jest to kwadrat o polu: " + bok1 * bok2);
            }
            else { Console.WriteLine("jest to prostokat o polu: " + bok2 * bok1); }
        }

        static void cw3()
        {
            Console.WriteLine("wprowadz liczbe: ");
            if (double.Parse(Console.ReadLine()) % 2 == 0)
            {
                Console.WriteLine("to liczba parzysta");
            }
            else { Console.WriteLine("to liczba nieparzysta"); }
        }
        static void cw4()
        {
            Console.WriteLine("Wprowadz 3 liczby: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > c)
            {
                if (a > b) { Console.WriteLine("liczba " + a + " jest najwieksza"); }
                else { Console.WriteLine("liczba " + b + " jest najwieksza"); }
            }
            else if (b > c) { Console.WriteLine("liczba " + b + "jest najwieksza"); }
            else { Console.WriteLine("liczba " + c + " jest najwieksza"); }
        }



        static void cw6()
        {
            Console.WriteLine("wprowadz liczbe zł: ");
            double zlote = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj walute: ([1]EUR,[2]USD,[3]CHF)");
            double wybor = double.Parse(Console.ReadLine());
            switch (wybor)
            {

                case 1:
                    Console.WriteLine("{0:F2} eur ", zlote / 4.56);
                    break;
                case 2:
                    Console.WriteLine("{0:F2} usd ", zlote / 4.32);
                    break;
                case 3:
                    Console.WriteLine("{0:F2} chf ", zlote / 4.77);
                    break;

            }


        }
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
            for(int j = 0; j <= 4; j++)
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
            for(int i=0;i<=4;i++)
            {
                if (punkty[i] > max) { max = punkty[i]; }
                if (punkty[i] < min) { min = punkty[i]; }
                oceny = oceny + punkty[i];
            }
            oceny = oceny - max - min;
            Console.WriteLine("wynik wynosi: "+ (pd + oceny));

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

        //CWICZENIA 3

        static void p31()
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
        static void p32()
        {
            double lokata = 6000;
            int i = 0;

            while (lokata!=2*lokata)
            {
                lokata = lokata + (lokata * 0.06);
                i++;
            }
            Console.WriteLine(i);
        }
        static void p33()
        {
            Random r = new Random();
            int n=r.Next(1,50);
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

            Console.WriteLine("brawo zgadles za "+i+" razem");

        }
        static void p34()
        {
            double liczba = 50;
            double liczba1 = 50;
            int i = 0;
            while (liczba % 2 != 1)
            {
                liczba = liczba / 2;
                i++;
            }
            if ((Math.Pow(2,i) != liczba1))
            {
                Console.WriteLine("to nie jesst potega 2");
            }
            else { Console.WriteLine(i); }
            
        }
        static void p35()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            
        }
        static void p36()
        {
            //while ((Math.PI / 4) - d)< d){

            
        }
    }
}
