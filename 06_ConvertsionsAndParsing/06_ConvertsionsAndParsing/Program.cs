// implicitely typed variables
var myFavouriteGenre = "Fantasy";

// explicitely typed variables
// implicit conversion
int myInt = 13;
double myDouble = myInt;
long myLong = 12345678901234;

float myFloat = 123.123f;
myDouble = myFloat;

// explicit confersion / casting
int myInt2 = (int) myLong;
myInt2 = (int)myDouble; 

myDouble = 13.212123213213332123;
myFloat = (float) myDouble;

double myDouble2 = 13.5;
int myInt3 = (int)myDouble2;

// Conversion helpers Parse and Convert
string numberString = "123";
int result = int.Parse(numberString);

string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);

Console.WriteLine(myDouble);
Console.ReadKey();