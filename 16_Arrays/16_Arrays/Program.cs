int num1 = 0;
int num2 = 1;   
int num3 = 2;
int num4 = 3;
int num5 = 4;

// declare an array
int[] myIntArray1 = new int[5];

// assign values to the array
myIntArray1[0] = num1;
myIntArray1[1] = num2;
myIntArray1[2] = num3;
myIntArray1[3] = num4;
myIntArray1[4] = num5;

Console.WriteLine(myIntArray1[3]);

// declare an array and set the array element values
int[] myIntArray2 = { 1, 2, 3, 4, 5, };

Console.WriteLine(myIntArray2[3]);
Console.WriteLine("Array lenght: " + myIntArray1.Length);

// iterate array with for loop
for (int i = 0; i < myIntArray1.Length; i++)
{
    Console.WriteLine(myIntArray1[i]);
}

// iterate array with foreach loop
foreach (var item in myIntArray2)
{
    Console.WriteLine(item);
}

// 2d array declaration
int[,] array2d = new int[3, 3];

// 3d array declaration
int[,,] array3d = new int[3, 3, 3];

int[,] array2dInitialized = { {1, 2}, {3, 4}, {5, 6} };

string[, ,] array3dInitialized = { 
    {
        { "O", "X", "X"},
        { "O", "O", "X"},
        { "X", "X", "O"},
    }, 
    {
        { "O", "X", "X"},
        { "O", "O", "X"},
        { "X", "X", "O"},
    }, 
    {
        { "O", "X", "X"},
        { "O", "O", "X"},
        { "X", "X", "O"},
    } 
};

Console.WriteLine("array2dInitialized [0,0]: " + array2dInitialized[0,0]);
Console.WriteLine("array3dInitialized [0,0,0]: " + array3dInitialized[0,0,0]);

string[,] ticTacToeField = {
    { "O", "X", "X"},
    { "O", "O", "X"},
    { "X", "X", "O"},
};

for (int i = 0; i < ticTacToeField.GetLength(0); i++)
{
    for (int j = 0; j < ticTacToeField.GetLength(1); j++)
    {
        Console.Write(" " + ticTacToeField[i,j] + "");
    }
    Console.WriteLine();
}

int[,,] array3d2 = {
                {
                    {1,2,3},
                    {4,5,6},
                    {7,8,9},
                },
            };

for (int i = 0; i < array3d2.GetLength(0); i++)
{
    for (int j = 0; j < array3d2.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < array3d2.GetLength(2); k++)
        {
            sum += array3d2[i, j, k];
        }
        Console.WriteLine(sum);
    }
}
