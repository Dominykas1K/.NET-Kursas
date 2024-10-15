//1uzduotis
///////////////////////////////////////////
//Console.WriteLine("Iveskite teksta");
//string text = Console.ReadLine();
//string changedText = text.Substring(0, 1).ToUpper() + text.Substring(1);

//Console.WriteLine(changedText);

//1 uzduotis 
///////////////////////////////////////////////////
//Console.WriteLine("Iveskite teksta");

//string text = Console.ReadLine();

//char[] changedText = text.ToCharArray();
//changedText[1] = 'g';
//changedText[3] = 'b';
//changedText[5] = '*';
//changedText[7] = 'x';
//changedText[9] = 'w';

//string result = new string(changedText);

//Console.WriteLine(result);

//2uzduotis
///////////////////////////////////////////////
//Console.WriteLine("Parasykite sakini");

//string input = Console.ReadLine();

//string result = input.Replace("a","uo");
//result = result.Replace("i","e");

//Console.WriteLine(result);


//2uzduotis
//////////////////////////////////////////////////////
//Console.WriteLine("Iveskite teksta");

//string input = Console.ReadLine();
//Console.WriteLine("Koki zodi noretumete pakeisti?");
//string input2 = Console.ReadLine();
//Console.WriteLine("I koki zodi noretumet pakeisti?");
//string input3 = Console.ReadLine();

//string pakeistasTekstas = input.Replace(input2,input3);

//Console.WriteLine(pakeistasTekstas);

//2uzduotis
//////////////////////////////////////////////////////////////

//Console.WriteLine("Įveskite savo amžių:");
//int dabartinisAmzius = Convert.ToInt32(Console.ReadLine());

//int likoMetu = 90 - dabartinisAmzius;

//if (likoMetu <= 0)
//{
//    Console.WriteLine("Jums jau 90 arba daugiau");
//}
//else
//{

//    int likoMenesiu = likoMetu * 12;
//    int likoSavaiciu = likoMetu * 52; 
//    int likoDienu = likoMetu * 365;   


//    Console.WriteLine("Jums liko:");
//    Console.WriteLine(likoMetu + " metu");
//    Console.WriteLine(likoMenesiu + " mėnesiu");
//    Console.WriteLine(likoSavaiciu + " savaičiu");
//    Console.WriteLine(likoDienu + " dienu iki 90 metu.");
//}

//3uzduotis
///////////////////////////////////////////


//Console.WriteLine("iveskite zodi");
//string input = Console.ReadLine();

//if (char.IsUpper(input[0]))
//{
//    Console.WriteLine(input.ToUpper());
//}
//else
//{
//    string changedInput = input.Substring(0, 1).ToUpper() + input.Substring(1);
//    Console.WriteLine(changedInput);
//}

//3uzduotis
////////////////////////////////////////////////////////////////////////
//Console.WriteLine("iveskite zodi");

//string input  = Console.ReadLine();

//if (input.Contains('a'))
//{ 
//    Console.WriteLine("a raides indeksas:" + input.IndexOf('a'));
//}
//else
//{
//    Console.WriteLine("Simbolis a nerastas");
//}


//3uzudotis
////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Iveskite zodi");
string input  = Console.ReadLine();
if (input.Contains("labas"))
{
    char[] simboliuMasyvas = input.ToCharArray();
    Array.Reverse(simboliuMasyvas); //simboliuMasyvas.Reverse();
    string atbulasZodis = new string(simboliuMasyvas);
    Console.WriteLine(atbulasZodis);
}
else
{
    Console.WriteLine(input);
}