//int i = 1;
//while (i <= 500000)
//{ 
//    Console.WriteLine(i);
//    i++;
//}

////////////////////////////////////////////////////////////////////
//using System;

//int i = 1;
//string result = "";
//while (i <= 5)
//{
//    Console.WriteLine("Iveskite teksta");
//    string input = Console.ReadLine();
//    result += " " + input;
//    i++;
//}
//Console.WriteLine(result);
///////////////////////////////////////////////////////////////////////
//int x = 1;
//int y = 1;

//while (x <=3)
//{
//    Console.WriteLine("Outer scope:" +x);

//    while(y<=3)
//    {
//        Console.WriteLine("Inner scope:" + y);
//        y++;
//    }

//    y = 1; //Nusstatom vidinio ciklo skaitliuka i pradine reiksme
//    x++;

//}




//1uzduotis
////////////////////////////////////////////////
//int i = 1;
//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}
//    while (i>=1)
//{
//    Console.WriteLine(i);
//    i--;
//}

//1 uzduotis
//////////////////////////////////////////
//int i = 2;
//while (i <= 10)
//{
//    Console.WriteLine(i);
//    i += 2;
//}
//int j = 1;
//while (j <= 9)
//{
//    Console.WriteLine(j);
//    j += 2;
//}
////////////////////////////////////////////

//3dalis
//////////////////////////////////////////////////////////////
//int i = 0;
//while (i <= 100)
//{
//    Console.WriteLine("Iveskite skaiciu didesni nei 100");
//    string input = Console.ReadLine();
//    i = Convert.ToInt32(input);

//}
//Console.WriteLine("Ivedete skaiciu didesni nei 100");




////////pazvizdys
////////int number;
////////bool isNumber = false;
////////do
////////{
////////    Console.WriteLine("Iveskte skaiciu: ");
////////    string input = Console.ReadLine();
////////    isNumber = int.TryParse(input, out number);
////////    if (isNumber )
////////    {
////////        Console.WriteLine("Irasete skaiciu");
////////    }
////////} while (!isNumber);

//1uzduotis
//int num = 0;
//do
//{
//    Console.WriteLine("Iveskite skaiciu");
//    string input = Console.ReadLine();
//    num = Convert.ToInt32(input);
//} while (num > 0);


Console.WriteLine("Iveskite skaiciu:");
int number = int.Parse(Console.ReadLine());

int faktorialas = 1;
int i = 1;
while (i <= number)
{
    faktorialas *= i;
    i++;
}
Console.WriteLine("faktorialas yra: " + faktorialas);