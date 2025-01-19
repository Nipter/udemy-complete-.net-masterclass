// modifier returnType MethodName(parameters) {
// codeblock
// }

// method definition
void MyFirstMethod()
{
    Console.WriteLine("MyFirstMethod was called");
}

// method definition with parameter
void WriteSomethingSpecific(string myString)
{
    Console.WriteLine(myString);
}
// method execution
MyFirstMethod();

// method execution with parameter
WriteSomethingSpecific("Called method WriteSomethingSpecific");

int AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}

Console.WriteLine(AddTwoValues(5, 10));