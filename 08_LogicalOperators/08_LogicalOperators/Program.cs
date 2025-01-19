
bool isRainy = false;
bool hasUmberlla = true;

// Logical Operators
// AND &&
// OR ||
// NOT !

// Variants of OR statments
// true || true -> true
// true || false -> true
// false || true -> true
// false || false -> false

// Variants of AND statments
// true && true -> true
// true && false -> false
// false && true -> false
// false && false -> false

if (isRainy || hasUmberlla)
{
    Console.WriteLine("Im safe from rain");
}

int num1 = 5;
int num2 = 6;

// relational operators
// <
// <=
// >
// >=
// ==
// !=

bool isGreater = num1 > num2;

if(isGreater)
{
    Console.WriteLine("Num1 is greater then num2");
}
else
{
    Console.WriteLine("Num1 is not greater then num2");
}
int age = 10;

if(age >= 18)
{
    if(age == 18)
    {
        Console.WriteLine("You had 18th birthday in this year");
    } else
    {
        Console.WriteLine("You are an Adult");
    }
    
} else if(age <= 8)
{
    Console.WriteLine("You are a child");
}  else
{
    Console.WriteLine("You are a teeneger");
}

int month = 2;
string monthName;

if (month == 1)
{
    monthName = "January";
}
else if (month == 2)
    monthName = "February";
else if (month == 3)
    monthName = "March";
else
    monthName = "Unknown";

switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName = "Unknown";
        break;
}
Console.WriteLine($"Month name: {monthName}");