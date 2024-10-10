using System.Runtime.CompilerServices;
//ctr + k + d
//1 Uzduotis
///////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Iveskite skaiciu");
//int number = Convert.ToInt32(Console.ReadLine());


//if (number > 100)
//{

//    Console.WriteLine("skaicius yra didesnis nei 100");

//}

//else if (number == 100)
//{

//    Console.WriteLine("skaicius yra lygus 100");


//}

//else if (number < 100)
//{

//    Console.WriteLine("skaicius yra mazesnis nei 100");

//}


// 1 Uzduotis
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Console.WriteLine("Iveskite dienos skaiciu");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number == 1)
//{
//    Console.WriteLine("Pirmadienis");
//}

//if (number == 2)
//{
//    Console.WriteLine("Antradienis");
//}

//if (number == 3)
//{
//    Console.WriteLine("Treciadienis");
//}

//if (number == 4)
//{
//    Console.WriteLine("Ketvirtadienis");
//}

//if (number == 5)
//{
//    Console.WriteLine("Penktadienis");
//}

//if (number == 6)
//{
//    Console.WriteLine("Siastadienis");
//}

//if (number == 7)
//{
//    Console.WriteLine("Sekmadienis");
//}
//else if (number > 7)
//{
//    Console.WriteLine("Neteisingas dienos skaicius");
//}


//2 uzduotis
////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 5 == 0)
//{
//    Console.WriteLine("skaicius yra lyginis arba skaicius dalijasi is 5");
//}
//else if (number % 5 == 1)
//{
//    Console.WriteLine("Skaicius neatitinka jokiu salygu");
//}

//2 uzduotis
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Kokia temperatura lauke?");

//int number = Convert.ToInt32(Console.ReadLine());

//if (number <= 0)
//{
//    Console.WriteLine("Lauke Salta");
//}

//else if (number >= 0 && number < 20)
//{
//    Console.WriteLine("Lauke vesu");
//}

//else if (number >= 20)
//{
//    Console.WriteLine("Lauke Karsta");
//}

// 3 Uzduotis
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Kelinta valanda pakilote?");

//int number = Convert.ToInt32(Console.ReadLine());


//if (number <= 12)
//{
//    Console.WriteLine("Geros dienos!");
//}

//else if (number >= 13 && number <= 18)
//{
//    Console.WriteLine("Geros popietes");

//}
//else if (number >= 19 || number == 24)
//{
//    Console.WriteLine("gero vakaro");
//}

// 3 Uzduotis 
////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Console.WriteLine("Iveskite slaptazodi");


//string input = Console.ReadLine();
//string correctPassword = "qwerty";
//string correctPassword2 = "Mellon";
//string hacked = "01101001 01101110";


//if (input == correctPassword || input == correctPassword2 )
//{
//    Console.WriteLine("Sekmingai prisijungete");
//}
//else if (input == hacked)
//{
//    Console.WriteLine("Nulausta");
//}

//else
//{
//    Console.WriteLine("Slaptažodis neteisingas, prašome bandyti dar kartą");
//}

//4 Uzduotis
/////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Iveskite savo amziu:");

//int input = Convert.ToInt32(Console.ReadLine());

//if (input < 18)
//{
//    Console.WriteLine("Jums priklauso nepilnamecio akcija!");
//}
//else if (input >= 18 && input < 65)
//{
//    Console.WriteLine("Jus esate suauges");
//}
//else //Kodel ne else?
//{
//    Console.WriteLine("Jums priklauso senjoro akcija");
//}

//5 Uzduotis
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Iveskite metu skaiciu");

//int input = Convert.ToInt32(Console.ReadLine());

//if (input % 4 == 0)
//{
//    Console.WriteLine("Tai yra keliamieji metai");
//}
//else
//{
//    Console.WriteLine("Tai nera keliamieji metai");
//}

//6 Uzduotis
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Iveskite skaiciu:");

//int input = Convert.ToInt32(Console.ReadLine());

//if (input % 3 == 0 && input % 5 == 0)
//{
//    Console.WriteLine("BazingaPop");
//}

//else if (input % 3 == 0)
//{
//    Console.WriteLine("Bazinga");
//}
//else if (input % 5 == 0)
//{
//    Console.WriteLine("Pop");
//}

//else
//{
//    Console.WriteLine(input);
//}

//7 Uzduotis 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Iveskite du skaicius");

//int input1 = Convert.ToInt32(Console.ReadLine());
//int input2 = Convert.ToInt32(Console.ReadLine());

//if (input1 > 0 && input2 > 0)
//{
//    Console.WriteLine("Abu skaiciai yra teigiami");
//}

//else if (input1 > 0 && input2 < 0)
//{
//    Console.WriteLine("Tik vienas skaicius teigiamas");
//}

//else if (input1 < 0 && input2 > 0)
//{
//    Console.WriteLine("Tik vienas skaicius teigiamas");
//}

//else if (input1 < 0 && input2 < 0) //esle
//{
//    Console.WriteLine("Ne vienas skaicius nera teigiams");
//}

//7 Uzduotis
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Iveskite tris skaicius");

//int input1 = Convert.ToInt32(Console.ReadLine());
//int input2 = Convert.ToInt32(Console.ReadLine());
//int input3 = Convert.ToInt32(Console.ReadLine());

//if (input1 % 2 == 0 && input2 % 2 == 0 && input3 % 2 == 0)
//{
//    Console.WriteLine("Visi skaiciai yra lygus");
//}

//else if (input1 % 2 == 0 && input2 % 2 == 0 && input3 % 1 == 0)
//{
//    Console.WriteLine("Bent du skaiciai yra lygus");
//}