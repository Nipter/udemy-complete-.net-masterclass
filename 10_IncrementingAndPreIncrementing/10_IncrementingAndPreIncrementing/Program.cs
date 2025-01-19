int num = 0;

Console.WriteLine($"Num is {num}");
// incrementing of int
num++;
Console.WriteLine($"Num is {num}");
// pre-incrementing of int
Console.WriteLine("Num is {0}", ++num);

Console.WriteLine("Num is {0}", num++);

Console.WriteLine($"Num is {num}");

Console.WriteLine($"Num is {num}");
// decrementing of int
num--;
Console.WriteLine($"Num is {num}");
// pre-decrementing of int
Console.WriteLine("Num is {0}", --num);

Console.WriteLine("Num is {0}", num--);

Console.WriteLine($"Num is {num}");

num += 30;

num -= 10;

num *= 10;

num /= 5;

Console.WriteLine($"Num is {num}");

num %= 5;

Console.WriteLine($"Num is {num}");

num += 3;

num %= 5;

Console.WriteLine($"Num is {num}");


Console.WriteLine("Give a number");

string inputString = Console.ReadLine();
int num1;
bool isNumber = int.TryParse(inputString, out num1);
if(!isNumber)
{
    Console.WriteLine("You entered wrong characters. Please enter a number");
}
num1++;

Console.WriteLine("User entered number + 1 = " + num1);