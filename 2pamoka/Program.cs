//komentaras

using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

string input = "Hello World!";

Console.WriteLine(input);

//3as kintamasis
string firstLine = "vienas";
string secondLine = "du";
string thirdLine = firstLine + secondLine;

Console.WriteLine(firstLine);

firstLine = firstLine + secondLine;

Console.WriteLine(firstLine);

Console.WriteLine(thirdLine);

// cw = Console.WriteLine("");


//indeksavimas
/////////////////////////////////////////////////

string city = "Vilnius";

int wordLenght = "Vilnius".Length;
int wordLenght2 = city.Length;

Console.WriteLine(wordLenght);
Console.WriteLine(wordLenght2);

string myImput2 = "CodeAcademy";
char mychar = myImput2[0];
Console.WriteLine(mychar);

int lastIndex = myImput2.Length - 1;
char lastChar = myImput2[lastIndex];

Console.WriteLine(lastChar);


//tuscios eilutes
/////////////////////////////////////////////////////
string word1 = "";
string word2;


//replace
////////////////////////////////////////////////////

string word3 = "mama";
string word4 = word3.Replace('m', 'p');

Console.WriteLine(word4);

//uzduotis nr 1
/////////////////////////////////////////////


string text = "uzduotis";
int wordLenght1 = text.Length;

Console.WriteLine(text);
Console.WriteLine(wordLenght1);

Console.WriteLine(text[3]);


//substring
////////////////////////////////////////////////////////////

string myWord5 = "Mano vardas Dominykas";

string myWordSubstring = myWord5.Substring(0, 11);
string myWordSubstring2 = myWord5.Substring(12);

Console.WriteLine(myWordSubstring);
Console.WriteLine(myWordSubstring2);


//indexOf
//////////////////////////////////////////////////////////////
int index1 = myWord5.IndexOf('M');

int index2 = myWord5.IndexOf("vardas");
Console.WriteLine(index1);
Console.WriteLine(index2);


//trim
/////////////////////////////////////////////////////////////
string myWord6 = "Mano vardas Dominykas            ";
Console.WriteLine(myWord6.Trim());


//Apjungti eilutes
string word7 = "ap", word8 = "gal", word9 = "voti";
//string myWord8 = "gal";
//string myWord9 = "voti";
string result = "";
result += word7;
result += word8;
result += word9;

string result2 = string.Concat(word7, word8, word9);

Console.WriteLine(result);

//ToString()
////////////////////////////////////////////////////////////
int number = 987;
string numberString = number.ToString();
string numbberSring2 = Convert.ToString(number);
string upperCase = numberString.ToUpper();
string lowerCase = numberString.ToLower();



























