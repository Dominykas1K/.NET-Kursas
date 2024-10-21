using System.Reflection;
using System.Xml;

namespace _9_pamoka_ref_ir_out
{
    internal class Program
    {
        static void Main(string[] args)
        {   //1dalis
            //int a = 5;
            //int b = 10;
            //Swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //2dalis
            //int skaicius1 = 5;
            //int skaicius2 = 3;
            //IncramentByN(ref skaicius1, skaicius2);
            //Console.WriteLine(skaicius1);

            //3dalis
            //string input = Console.ReadLine();

            //TrimAndCapitalize(ref input);

            //Console.WriteLine(input);

            //2uzduotis 1 dalis
            //GetUserData(out string vardas, out string pavarde);
            //Console.WriteLine($"Vardas: {vardas}, Pavarde:{pavarde}");

            //2uzduotis 2dalis

            //int i;
            //while (true)
            //{
            //    Console.WriteLine("iveskite skaiiciu didesni uz 100");
            //    string input = Console.ReadLine();

            //    if(int.TryParse(input, out i))
            //    {
            //        if (i > 100)
            //        {
            //            Console.WriteLine("Skaicius yra didesnis nei 100");
            //        }
            //        else
            //        {
            //            Console.WriteLine("skaicius per mazas");
            //        }
            //    }

            //}

           


        }
        static void Swap(ref int x, ref int y)
        {
            int skaicius = x;
            x = y;
            y = skaicius;
        }

        static void IncramentByN(ref int skaicius1,  int skaicius2)
        {
         skaicius1 += skaicius2;
    }

        static void TrimAndCapitalize(ref string input)
        {
            input = input.Trim();
           input =  input.Substring(0, 1).ToUpper() + input.Substring(1);

        }

        static void GetUserData(out string vardas, out string pavarde )
        {
            Console.WriteLine("Irasykite varda:");
             vardas = Console.ReadLine();
            Console.WriteLine("Irasykite pavarde:");
            pavarde = Console.ReadLine();
        }

    }
}
