string question1 = "What is the capital of Poland";
string answer1 = "Poland";

string question2 = "What is 2 + 2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnswer = Console.ReadLine();
if(userAnswer.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct");
    score++;
} 
else
{
    Console.WriteLine("Wrong, correct answer is: " + answer1);
}

Console.WriteLine(question2);
userAnswer = Console.ReadLine();
if (userAnswer.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, correct answer is: " + answer2);
}

Console.WriteLine(question3);
userAnswer = Console.ReadLine();
if (userAnswer.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, correct answer is: " + answer3);
}

Console.WriteLine($"Quiz completed! Your final score is: {score}/3");

if(score == 3)
{
    Console.WriteLine("Perfect score");
} else if(score > 0)
{
    Console.WriteLine("Not bad");
} else
{
    Console.WriteLine("Well, try again");
}