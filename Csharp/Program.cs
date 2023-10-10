using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cw6();
        }

        static void cw1()
        {
            Console.WriteLine("Wprowadz promien: ");
            double promien = double.Parse(Console.ReadLine());
            Console.WriteLine("Pole wynosi: " + Math.PI * Math.Pow(promien, 2));
#dsa

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
                    Console.WriteLine("{0:F2} eur ",  zlote / 4.56);
                    break;
                case 2:
                    Console.WriteLine("{0:F2} usd " , zlote / 4.32);
                    break;
                case 3:
                    Console.WriteLine("{0:F2} chf " , zlote / 4.77);
                    break;

            }


        }
    }
}
