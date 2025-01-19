// for loop
using System;

string myString = "Hi \nHi";

//for (int i = 0; i <= 10; i++)
//{
//    Console.Clear();
//    Console.WriteLine($"I is: {i}");
//    Console.WriteLine(myString);
//    //Thread.Sleep(200);
//}

//for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine($"I is: {i}");
//}

// while loop
//int j = 0;
//while (j < 10)
//{
//    Console.WriteLine($"J is: {j}");
//    j++;
//}

//Console.WriteLine("Enter go or stay");
//string userChoice = Console.ReadLine();

//while (userChoice == "go")
//{
//    Console.WriteLine("Go for a mile");
//    userChoice = Console.ReadLine();
//}

//Console.WriteLine("Enter guess number");
//int numberToGuess = 10;
//Random random = new Random();
//int userGuess = random.Next(1, 10);


//while (userGuess != numberToGuess)
//{
//    int.TryParse(Console.ReadLine(), out userGuess);
//    if (userGuess < numberToGuess)
//    {
//        Console.WriteLine("Too low");
//    }
//    else
//    {
//        Console.WriteLine("Too heigh");
//    }   
//}
//Console.WriteLine("Guessed");

// do while loop
//Random random = new Random();
//int randomCounter = random.Next(1, 10);
//do
//{
//    Console.WriteLine("Counter: " + randomCounter);
//    randomCounter++;
//}
//while (randomCounter < 10);

// break
for (int i = 0; i < 10; i++)
{
    if(i ==5)
    {
        break;
    }
    Console.WriteLine("I:" + i);
}

// continue
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine("I:" + i);
}

