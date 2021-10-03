using System;

namespace Game_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("------------------------");
            Console.WriteLine(" 1.Play game ");
            Console.WriteLine(" 2.Exit ");
            Console.WriteLine("------------------------");
            int x = 0;
            while (x == 0)
            {
                Console.Write("Please Select Menu : ");
                int number = int.Parse(Console.ReadLine());//input number for choose menu 
                if (number == 1)
                {
                    Console.WriteLine("Play Game Hangman");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect Score: 0 ");
                    string[] words = new string[3] { "Tennis", "Football", "Badminton" };

                    Random random = new Random();
                    int resultRandom = random.Next(0, 2);
                    string word = words[resultRandom];
                    char[] guess = new char[word.Length];
                    chackRandom(resultRandom, word, guess);

                }
                else if (number == 2)
                {
                    Console.WriteLine(); break;
                }
            }

            static void chackRandom(int resultRandom, string myword, char[] guess)
            {
              
                    if (resultRandom == 0)
                    {
                        Console.WriteLine("_ _ _ _ _ _");
                    }
                    else if (resultRandom == 1)
                    {
                        Console.WriteLine("_ _ _ _ _ _ _ _");
                        
                    }
                    else if (resultRandom == 2)
                    {
                        Console.WriteLine("_ _ _ _ _ _ _ _ _");
                    }
                Play_Game(myword, guess);
                
            }
            static void Play_Game(string word, char[] guess)
            {
                for (int i = 0; i < word.Length; i++) { guess[i] = '-'; }
                {
                    int n = 0;
                    int m = 0;
                    while (m == 0)
                    {
                        char playerGuess = char.Parse(Console.ReadLine());
                        for (int j = 0; j < word.Length; j++)
                        {
                            if (playerGuess == word[j])
                            {
                                guess[j] = playerGuess;

                            }
                        }
                        n = n + 1;
                        Console.WriteLine("Incorrect Score: {0}", n);
                        Console.WriteLine(guess);
                    }
                }
            }
        }
    }
}
    

