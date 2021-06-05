using System;

namespace homework6.1
    {

struct Difficultylavel
{
    public Difficulty difficulty;
}
enum Difficulty
{
    Easy,
    Normal,
    Hard
}
struct Problem
{
    public string Message;
    public int Answer;
    public Problem(string message, int answer)
    {
        Message = message;
        Answer = answer;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int Difficultycorde = 0;
        double ScoreNow = 0;
        int Score = 0;

        Console.Write("Score: {0} ,", ScoreNow);
        Console.WriteLine("Difficulty: Easy ");
        for (int L = 0; L <= 100; L++)
        {
            Console.Write("The page you want: ");
            int page = int.Parse(Console.ReadLine());
            if (page == 0)
            {
                Console.WriteLine("play game");
                play(ref Difficultycorde, Score, ref ScoreNow);
            }
            else if (page == 1)
            {
                Console.WriteLine("Setting");
                Difficultylavel difficulty1;
                Difficultycorde = int.Parse(Console.ReadLine());
                difficulty1.difficulty = (Difficulty)Difficultycorde;
                Console.WriteLine("Difficulty : {0} ", difficulty1.difficulty.ToString());

            }
            else if (page == 2)
            {
                Console.WriteLine("log out"); break;
            }
            else
            {
                Console.WriteLine("Please input 0 - 2");
            }
        }
    }

    static void play(ref int Difficultycorde, int Score, ref double ScoreNow)
    {
        double Qc = 0;
        int numProblem = (2 * Difficultycorde) + 3;

        long x = DateTimeOffset.Now.ToUnixTimeSeconds();
        for (int j = 0; j < numProblem; j++)
        {
            Problem[] randomArray;
            randomArray = GenerateRandomProblems(numProblem);
            Console.WriteLine("Message :{0}", randomArray[0].Message);
            int ans = int.Parse(Console.ReadLine());
            if (ans == randomArray[0].Answer)
            {
                Qc = Qc + 1;
            }
        }
        long y = DateTimeOffset.Now.ToUnixTimeSeconds();
        ScoreNow = (Qc / numProblem) * ((25 - Difficultycorde * Difficultycorde)
           / (Math.Max((y - x), 25 - Math.Pow(Difficultycorde, 2)))
           * (Difficultycorde * Difficultycorde) + 1);

        ScoreNow = +ScoreNow;
        Console.WriteLine("Score: {0} ,", ScoreNow);

    }

    static Problem[] GenerateRandomProblems(int numProblem)
    {
        Problem[] randomProblems = new Problem[numProblem];

        Random rnd = new Random();
        int x, y;

        for (int i = 0; i < numProblem; i++)
        {
            x = rnd.Next(50);
            y = rnd.Next(50);
            if (rnd.NextDouble() >= 0.5)
                randomProblems[i] =
                new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
            else
                randomProblems[i] =
                new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
        }

        return randomProblems;
    }

}

    

