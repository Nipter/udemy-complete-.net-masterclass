// creating an instance of the Random Class
Random random = new Random();
// generates number between 1 and 10
int randomNumber = random.Next(1, 11);

Console.WriteLine("Enter a number");

string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);    

if(isNumber)
{
    if (randomNumber == num1)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("Random number: {0}", randomNumber);
        Console.WriteLine("You gussed wrong, try again!");
    }
} 
else
{
    Console.WriteLine("Please provide correct number");
}


