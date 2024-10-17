using System.ComponentModel.Design;

// 1uzduotis 1dalis
//namespace _7_pamoka_Metodai
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Iveskite slaptazodi ilgesni nei 8 simboliu");
//            string input = Console.ReadLine();
//            if (IsCorrectPassword(input))
//            {
//                Console.WriteLine("slaptazodis tinkamas");
//            }
//            else
//            {
//                Console.WriteLine("Slaptazodis yra per trumpas.");
//            }

//        }
//        public static bool IsCorrectPassword(string input)
//        {
//            if (input.Length >= 8)
//            {
//                return true;

//            }
//            else
//            {
//                return false;
//            }
//        }



//    }
//}







//1uzduotis 2 dalis
//namespace _7_pamoka_Metodai
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Iveskite El. Pasta");
//            string input = Console.ReadLine();
//            if (IsEmailValid(input))
//            {
//                Console.WriteLine("El. Pastas tinkamas");
//            }
//            else
//            {
//                Console.WriteLine("El. Pastas netinkamas");
//            }
//        }
//        public static bool IsEmailValid(string input)
//        {
//            if (input.Contains('@'))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}


//1uzduotis 3 dalis
//namespace _7_pamoka_Metodai
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Iveskite suma doleriais");
//            double suma = Convert.ToDouble(Console.ReadLine());
//            double euros = ConvertToEuros(suma);
//            Console.WriteLine(suma + " " + "doleriai yra:" + " " + euros + " " + "eurai");
//        }
//        public static double ConvertToEuros(double suma)
//        {
//            double exhangeRate = 0.85;
//            double euros = suma * exhangeRate;
//            return euros;
//        }
//    }
//}


//2uzduotis 1dalis
//namespace _7_pamoka_Metodai
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Parasykite varda");
//            string input1 = Console.ReadLine();
//            Console.WriteLine("Parasykite pavarde");
//            string input2 = Console.ReadLine();
//            string vardasPavarde = GetInitials(input1, input2);
//            Console.WriteLine(vardasPavarde);
//        }
//        public static string GetInitials(string input1, string input2)
//        {
//            return input1 + " " + input2;
//        }

//    }
//}


//2uzduotis 2 dalis
//namespace _7_pamoka_Metodai
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Iveskite cilindro spinduli ");
//            double input1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Iveskite cilindro auksti");
//            double input2 = Convert.ToDouble(Console.ReadLine());
//            double result = CalculateCylinderVolume(input1, input2);
//            Console.WriteLine("Cilindro turis yra:" + " " + result);

//        }
//        public static double CalculateCylinderVolume(double input1, double input2)
//        {
//            double result = Math.PI * Math.Pow(input1, 2) * input2;
//            return result;
//        }
//    }
//}


//2 uzduoties 3 dalis
namespace _7_pamoka_Metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveksite skaiciu");
            int input = Convert.ToInt32(Console.ReadLine());
            bool result = IsNumberEven(input);
            Console.WriteLine(result);
        }
        public static  bool IsNumberEven(int input)
        {
            if (input > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     
    }
}