using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            p23();
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
        static void p21()
        {
            int suma = 0;
            int ocena;
            int liczba = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                if (ocena>= 3)
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
            lokata=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj na ile lat jest lokata: ");
            lata=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= lata; i++)
            {
                lokata = lokata + lokata * 0.06;
            }
            Console.WriteLine("lokata po naliczeniu odsetek wynosi: {0:F2}", lokata) ;
        }
        static void p23()
        {
            double max = Convert.ToDouble(Console.ReadLine());
            double min = max;

            for ( int i = 2; i <= 5; i++)
            {
                double liczba1 = Convert.ToDouble(Console.ReadLine());
                if (liczba1 > max)
                {
                    max = liczba1;
                }
                else if(liczba1 < min) { min = liczba1; }
                

            }
            Console.WriteLine("Najwieksza liczba to " + max + "a najmniejsza to: " + min);
        }
    }
}
