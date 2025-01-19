int num1;
int num2;

Console.WriteLine("Enter the first number:");
bool isNum1 = int.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("Enter the second number:");
bool isNum2 = int.TryParse(Console.ReadLine(), out num2);

if (!isNum1 || !isNum2)
{
    Console.WriteLine("Incorrect input");
}
else
{
    Console.WriteLine("Choose an operation: +, -, *, /");

    string operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            Console.WriteLine($"Result: {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"Result: {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"Result: {num1 * num2}");
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"Result: {num1 / num2}");
            }
            break;
        default:
            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            break;
    }
}