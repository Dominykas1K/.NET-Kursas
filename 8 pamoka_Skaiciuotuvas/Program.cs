using System;

namespace _8_pamoka_Skaiciuotuvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meniu();

        }
        public static void Meniu()
        {
            Console.WriteLine("Skaiciuotuvo meniu:");
            Console.WriteLine("1 - Sudetis");
            Console.WriteLine("2 - Atimtis");
            Console.WriteLine("3 - Daugyba");
            Console.WriteLine("4 - Dalyba");
            Console.WriteLine("5 - Saknis");
            Console.WriteLine("6 - Pakelimas laipsniu");
            Console.WriteLine(" Spauskite q noredami uzdaryti programa");

            string pasirinkimas = Console.ReadLine();          

            switch (pasirinkimas)
            {
                case "1":
                    Console.WriteLine("Pasirinkote sudeti");
                    Console.WriteLine("Iveskite pirma skaiciu");
                    double skaicius1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite antra skaiciu");
                    double skaicius2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultatas yra:" + " " + Sudetis(skaicius1, skaicius2));
                    break;
                case "2":
                    Console.WriteLine("Pasirinkote atimti");
                    Console.WriteLine("Iveskite pirma skaiciu");
                    double skaicius3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite antra skaiciu");
                    double skaicius4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultatas yra:" + " " + Atimtis(skaicius3,skaicius4));
                    break;
                case "3":
                    Console.WriteLine("Pasirinkote daugyba");
                    Console.WriteLine("Iveskite pirma skaiciu");
                    double skaicius5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite antra skaiciu");
                    double skaicius6 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultatas yra:" + " " + Daugyba(skaicius5,skaicius6));
                    break;
                case "4":
                    Console.WriteLine("Pasirinkote dalyba");
                    Console.WriteLine("Iveskite pirma skaiciu");
                    double skaicius7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite antra skaiciu");
                    double skaicius8 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultatas yra:" + " " + Dalyba(skaicius7, skaicius8));
                    break;
                case "5":
                    Console.WriteLine("Pasirinkote sakni");
                    Console.WriteLine("Iveskite skaiciu is kurio noretumete istraukti sakni");
                    double skaicius9 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultatas yra:" + " " + Saknis(skaicius9));
                    break;
                case "6":
                    Console.WriteLine("Pasirinkote kelima laipsniu");
                    Console.WriteLine("Iveskite pirma skaiciu");
                    double skaicius10 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite antra skaiciu");
                    double skaicius11 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultatas yra:" + " " + PakelimasLaipsniu(skaicius10, skaicius11));
                    break;
                    default:
                    Console.WriteLine("Netinkamas pasirinkimas, bandykite dar karta");
                    break;
            }
        }

        public static double Sudetis(double a, double b)
        {
            return a + b;
        }

        public static double Atimtis(double a, double b)
        {
            return a - b;
        }

        public static double Daugyba(double a, double b)
        {
            return a * b;
        }
        public static double Dalyba(double a, double b)
        {
            return a / b;
        }
        public static double Saknis (double a)
        {
            return Math.Sqrt(a);
        }
        public static double PakelimasLaipsniu(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
