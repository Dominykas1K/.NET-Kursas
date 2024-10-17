//int day = 3;
//switch (day) 
//{
//    case 1:
//        Console.WriteLine("Pirmadienis");
//        break;
//    case 2:
//        Console.WriteLine("antradienis");
//        break;
//    case 3:
//        Console.WriteLine("treciadienis");
//        break;
//    default:
//        Console.WriteLine("neteisinga diena");
//        break;

//}

//int operation = 1;
//string result = operation switch
//{
//    1 => "Case 1",
//    2 => "Case 2",
//    3 => "Case 3",
//    _ => "Default Case"

//};

//Console.WriteLine(result);

// 1uzduotis
/////////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Irasykite dienos skaiciu");

//int input = Convert.ToInt32(Console.ReadLine());

//switch (input)
//{
//    case 1:
//        Console.WriteLine("Pirmadienis");
//        break;

//    case 2:
//        Console.WriteLine("Antradienis");
//        break;

//    case 3:
//        Console.WriteLine("Treciadienis");
//        break;
//    case 4:
//        Console.WriteLine("Ketvirtadienis");
//        break;
//    case 5:
//        Console.WriteLine("Penktadienis");
//        break;
//    case 6:
//        Console.WriteLine("Siastadienis");
//        break;
//    case 7:
//        Console.WriteLine("Sekmadienis");
//        break;
//    default:
//        Console.WriteLine("Tokios dienos nera");
//        break;
//}

//1 uzduotis
//////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Iveskite savo amzius");

//int input = Convert.ToInt32(Console.ReadLine());
//string result = input switch
//{
//    > 7 and < 18 => "moksleivis",
//    <19 and < 25 => "Studentas",
//    <26 and < 65  => "Darbuotojas",
//    <66 and < 100 => "Pensininkas",
//    _ =>""
//};
//Console.WriteLine(result);

//1 uzduotis
///////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Irasykite menesio numeri");

//int input = Convert.ToInt32(Console.ReadLine());

//switch (input)
//{
//    case 1:
//        Console.WriteLine("sausis");
//        break;
//    case 2:
//        Console.WriteLine("Vasaris");
//        break;
//    case 3: 
//        Console.WriteLine("Kovas");
//        break;
//    case 4: 
//        Console.WriteLine("Balandis");
//        break;
//    case 5: 
//        Console.WriteLine("Geguze");
//        break;
//    case 6: 
//        Console.WriteLine("Birzelis");
//        break;
//    case 7: 
//        Console.WriteLine("Liepa");
//        break;
//    case 8: 
//        Console.WriteLine("Rugpjutis");
//        break;
//    case 9:
//        Console.WriteLine("Rugsejis");
//        break;
//    case 10:
//        Console.WriteLine("Spalis");
//        break;
//    case 11:
//        Console.WriteLine("Lapkritis");
//        break;
//    case 12:
//        Console.WriteLine("Gruodis");
//        break;
//    default:
//        Console.WriteLine("Tokio menesio nera");
//        break;
//}



//2 uzduotis
///////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Iveskite figura:");
Console.WriteLine("");
Console.WriteLine("Kvadratas");
Console.WriteLine("Apskritimas");
Console.WriteLine("Trikampis");
Console.WriteLine("Staciakampis");
Console.WriteLine("");
string figura = Console.ReadLine();
switch (figura)
{
    case "Kvadratas":
        Console.WriteLine("Iveskite kvadrato krastines ilgi:");
        double krastine = Convert.ToDouble(Console.ReadLine());
        double resultatas = (krastine * krastine);
        Console.WriteLine(resultatas);
        break;
    case "Apskritimas":
        Console.WriteLine("Iveskite apskritimo spinduli");
        double spindulys = Convert.ToDouble(Console.ReadLine());
        double resultatas1 = (Math.PI * Math.Pow(spindulys, 2));
        Console.WriteLine(resultatas1);
        break;
    case "Trikampis":
        Console.WriteLine("Iveskite Trikampio aukstine");
        double aukstine = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Iveskite trikampio pagrinda");
        double pagrindas = Convert.ToDouble(Console.ReadLine());
        double resultatas2 = (1 / 2 * aukstine * pagrindas);
        Console.WriteLine(resultatas2);
        break;
    case "Staciakampis":
        Console.WriteLine("Iveskite staciakampio ilgi");
        double ilgis = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Iveskite staciakampio ploti");
        double plotis = Convert.ToDouble(Console.ReadLine());
        double resultatas3 = (ilgis * plotis);
        Console.WriteLine(resultatas3);
        break;
    default:
        Console.WriteLine("Ivesta netaisiklinga figura");
        break;
}


//2 uzduotis
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Pasirinkite viena is siu elementu:");
//Console.WriteLine("Ugnis");
//Console.WriteLine("Vanduo");
//Console.WriteLine("Oras");
//Console.WriteLine("Zeme");

//string elementas = Console.ReadLine();
//switch (elementas)
//{
//    case "ugnis":
//        Console.WriteLine("Ugnies savybe yra: karstis, sviesa ir degimas.");
//        break;
//    case "Vanduo":
//        Console.WriteLine("Vandens savybe yra: skystumas, dregme");
//        break;
//    case "Oras":
//        Console.WriteLine("Oro savybe yra: skaidrumas, judejimas ir dujine forma");
//        break;
//    case "Zeme":
//        Console.WriteLine("Zemes savybe yra: kietumas, sunkumas ir tvirtumas");
//        break;
//    default:
//        Console.WriteLine("Tokio elemnento nera");
//        break;
//}

////2 uzduotis
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Iveskite specialybe");
//Console.WriteLine("Matematika");
//Console.WriteLine("Informatika");
//Console.WriteLine("Biologija");
//Console.WriteLine("Chemija");
//string specialybe = Console.ReadLine();




