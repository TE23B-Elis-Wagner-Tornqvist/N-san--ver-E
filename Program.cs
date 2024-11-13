// if(6>=3)
// {
// Console.WriteLine("Hello, World!");
// Console.ReadLine();
// }


//Uppgift 2
// string name = Console.ReadLine() ?? string.Empty;
// if(name.ToLower() == "noname")
// {
//     Console.WriteLine("Welcome!");
//     Console.ReadLine();
// }

//Uppgift 3
// Console.WriteLine("Användarnamn och lösenord tack");
// string name = Console.ReadLine() ?? string.Empty;
// string password = Console.ReadLine() ?? string.Empty;
// if(name.ToLower() == "noname" && password.ToLower() == "nopass")
// {
//     Console.WriteLine("Welcome!");

// } else {
//     Console.WriteLine("Wrong username or password");

// }

// Console.ReadLine();


//uppgift 4
// for (int i = 0; i < 32; i++)   
// {
//     Console.WriteLine("Hello World!");
// }

// Console.ReadLine();


//uppgift 5 

// bool answer = true;

// while(answer == true)
// {


// Console.WriteLine("Användarnamn och lösenord tack");
// string name = Console.ReadLine() ?? string.Empty;
// string password = Console.ReadLine() ?? string.Empty;
// if(name.ToLower() == "noname" && password.ToLower() == "nopass")
// {
//     Console.WriteLine("Welcome!");
//     answer = false;

// } else {
//     Console.WriteLine("Wrong username or password");

// }

// }

// Console.ReadLine();


//uppgift 6

// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine("Skirv ett tal");
//     string number = Console.ReadLine() ?? string.Empty;
//     int numberInt = 0;
//     int.TryParse(number, out numberInt);

//     if(numberInt > 5)
//     {
//         Console.WriteLine("Högre än 5!");
//     }

// }

// Console.ReadLine();


// uppgift 7


// while (true)
// {

//     Console.WriteLine("Skriv något");

//     string answer = Console.ReadLine() ?? string.Empty;
//     int answerInt = 0;
//     bool success = int.TryParse(answer, out answerInt);

//     if (success == true)
//     {
//         Console.WriteLine("blev rätt");
//         break;
//     }

//     if (success != true)
//     {
//         Console.WriteLine("blev fel");

//     }
// }


//uppgift 8, sista

// int randomNumber = Random.Shared.Next(1, 101);

// while(true)
// {

// Console.WriteLine("gissa ett tal som är mellan 1 - 100");

// string guess = Console.ReadLine() ?? string.Empty;
// int guessInt = 0;
// bool success = int.TryParse(guess, out guessInt);

// if(success == true && guessInt == randomNumber)
// {
//     Console.WriteLine("Helt rätt, snyggt jobbat!");
//     break;
// }

// if(success == true && guessInt < randomNumber)
// {
//     Console.WriteLine("Det där är lite för lågt tyvärr ):");

// }

// if(success == true && guessInt > randomNumber)
// {
//     Console.WriteLine("Det där är lite för högt grabben");

// }

// if(success == false)
// {
//     Console.WriteLine("Försök igen! Du ska skriva ett nummer kom ihåg!");
// }



// }

// Console.ReadLine();




//Näsan över E, 2. Uppgift 1 och uppgift 2


//string[] toys = ["rpg", "teddybjörn", "PC", "50kr", "godis"];

// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine(toys[i]);

// }
// Console.ReadLine();


//2, uppgift 3


//string[] names = ["teo", "elis", "oscar", "anton", "thor"];


//2, uppgift 4

//string[] numbers = ["3", "8", "5", "9", "10"];


//2, uppgift 5



// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"{names[i]} ger {toys[i]} betyget {numbers[i]}");
// }
// Console.ReadLine();


//2, uppgift 6, 7 och 8

// List<string> cities = new List<string>();

// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine("skriv något");
//     string answer = Console.ReadLine() ?? string.Empty;
//     cities.Add($"{answer}");

//     if(answer.ToLower() == "exit")
//     {
//         break;
//     }
//     Console.WriteLine($" Du la till {cities[i]}");

// }

// Console.WriteLine("Här är din lista:");
// for(int s = 0; s < 5; s++)
// {
//     Console.WriteLine($"{cities[s]}");
// }
// Console.ReadLine();


//Näsan över E: 3, uppgift 1


// void hello32()
// {
//     for(int i = 0; i < 32; i++)
//     {
//         Console.WriteLine("Hello World!");
//     }
// }


// hello32();

// Console.ReadLine();


//3, uppgift 2
// int qudrant = 35;

// void Bro (int qudrant)
// {
//     Console.WriteLine($"{qudrant * qudrant}");
// }

// Bro(qudrant);

// Console.ReadLine();



//3, uppgift 3


// float H = 2;
// float S = 5;

// static void Multi(float H, float S)
// {
// Console.WriteLine($"{ H * S}");
// }

// Multi(H, S);

// Console.ReadLine();



//3, uppgift 4

// float r = RightTriangleArea(5, 7);
// float r2 = RightTriangleArea(10, 6);


// static float RightTriangleArea(float b, float h)
// {
//     return b * h / 2;
// }

// Console.WriteLine($"{r * r2}");

// Console.ReadLine();


//3, uppgift 5



// static float AreaCircle(float r)
// {
//     return r * r * MathF.PI;
// }

// Console.WriteLine($"{AreaCircle(5)}");

// Console.ReadLine();



//3, uppgift 6

// void GetNumberInt()
// {

//     while(true)
//     {

//     Console.WriteLine("Skirv ett nummer");

//     string answer = Console.ReadLine() ?? string.Empty;
//     int answerInt = 0;
//     bool success = int.TryParse(answer, out answerInt);

//     if(success == true)
//     {
//         Console.WriteLine($"{answer}");
//         break;
//     }

//     }
    

// }

// GetNumberInt();

// Console.ReadLine();



//3, uppgift 7

string text = "godis";
string text2 = "glass";
string text3 = "chips";

void  GetChoice(string text, string text2, string text3)
{
    while(true)
    {

    

    Console.WriteLine($"Val 1: {text}  val 2: {text2}  val 3 {text3},  skriv vilket nummer du vill ha");

    string answer = Console.ReadLine() ?? string.Empty;
    int answerInt = 0;
    bool success = int.TryParse(answer, out answerInt);

  if(success == true)
  {

     if(answerInt == 1)
    {
        Console.WriteLine($" du valde {text}");

    }

    else if(answerInt == 2)
    {
        Console.WriteLine($" du valde {text2}");
    }

    else if(answerInt == 3)
    {
        Console.WriteLine($" du valde {text3}");
    }

    break;

  }

  if(success == false)
  {
    Console.WriteLine("SKRIV ETT NUMMER");
    continue;
  }

    }

}


GetChoice(text, text2, text3);
Console.ReadLine();