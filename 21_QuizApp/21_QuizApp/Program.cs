namespace _21_QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Poland?", 
                new string[] {"Paris", "Warsow", "London", "Madrid"},
                1)        ,        
                new Question("What is 2 + 2?", 
                new string[] {"1", "2", "3", "4"},
                3)
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }
}
