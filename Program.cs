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

int randomNumber = Random.Shared.Next(1, 101);

while(true)
{

Console.WriteLine("gissa ett tal som är mellan 1 - 100");

string guess = Console.ReadLine() ?? string.Empty;
int guessInt = 0;
bool success = int.TryParse(guess, out guessInt);

if(success == true && guessInt == randomNumber)
{
    Console.WriteLine("Helt rätt, snyggt jobbat!");
    break;
}

if(success == true && guessInt < randomNumber)
{
    Console.WriteLine("Det där är lite för lågt tyvärr ):");
    
}

if(success == true && guessInt > randomNumber)
{
    Console.WriteLine("Det där är lite för högt grabben");
    
}

if(success == false)
{
    Console.WriteLine("Försök igen! Du ska skriva ett nummer kom ihåg!");
}



}

Console.ReadLine();