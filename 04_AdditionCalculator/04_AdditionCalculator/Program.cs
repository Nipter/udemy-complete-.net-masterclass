using System.Globalization;

Console.WriteLine("Enter numbers!");

// datatype variableName = initial value;
double myNumber1 = 0.0;
double myNumber2 = 0.0;

myNumber1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
myNumber2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double sum = myNumber1 + myNumber2;
sum = Math.Round(sum, 2);   

// strings concatenation 
//Console.WriteLine("You entered: " + myNumber1 + ", " + myNumber2 + ". The addition result is: " + sum);

// strings interpolation 
//Console.WriteLine($"You entered: {myNumber1.ToString(CultureInfo.InvariantCulture)}, " +
//    $"{myNumber2.ToString(CultureInfo.InvariantCulture)}. The addition result is: {sum.ToString(CultureInfo.InvariantCulture)}");

// string formatting
Console.WriteLine("You entered: {0}, {1}. The addition result is: {2}", myNumber1, myNumber2, sum);

Console.ReadKey();
