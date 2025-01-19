int currentScore;
int sum = 0;
int counter = 0;

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish!");
    int.TryParse(Console.ReadLine(), out currentScore);
    if(currentScore != -1)
    {
        sum = sum + currentScore;
    }
    counter++;
}
while (currentScore != -1);

int average = sum / counter;

Console.WriteLine("Average: " + average);