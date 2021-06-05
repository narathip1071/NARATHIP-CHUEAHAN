using System;

namespace homework6._2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Page 0 : Calculate grade");
                Console.WriteLine("Page 1 : Calculate GPA");
                Console.WriteLine();
                Console.Write("Select page: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.Write("Your Score is: ");
                    int Score = int.Parse(Console.ReadLine());
                    chargeGrade(Score);
                }
                else if (num == 1)
                {
                    chargeGPA(num);
                }
                else
                {
                    Console.WriteLine();
                }
            
        }
        static void chargeGrade(int Score)
        {
            if (Score > 89)
            {
                Console.WriteLine("Score: {0} , Grade: A ", Score);
            }
            else if (Score <= 89& Score > 79)
            {
                Console.WriteLine("Score: {0} , Grade: B+ ", Score);
            }
            else if (Score <= 79 & Score > 69)
            {
                Console.WriteLine("Score: {0} , Grade: B ", Score);
            }
            else if (Score <= 69 & Score >59 )
            {
                Console.WriteLine("Score: {0} , Grade: C+ ", Score);
            }
            else if (Score <= 59 & Score > 49)
            {
                Console.WriteLine("Score: {0} , Grade: C ", Score);
            }
            else if (Score <= 49 & Score > 39)
            {
                Console.WriteLine("Score: {0} , Grade: D+ ", Score);
            }
            else if (Score <= 39 & Score > 29)
            {
                Console.WriteLine("Score: {0} , Grade: D ", Score);
            }
            else if (Score <29)
            {
                Console.WriteLine("Score: {0} , Grade: F ", Score);
            }
        }
        static void chargeGPA(int num)
        {
            Console.Write("how many supject ;");
            int nummany = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double Totolcgrade = 0;
            double Totolcredits = 0;
            for (int i = 0; i < nummany; i++)
            {
                Console.Write("grade{0}: ", i + 1);
                string grade = Console.ReadLine();
                Console.Write("credits{0}: ", i + 1);
                double credits = int.Parse(Console.ReadLine());
                Totolcredits += credits;
                Totolcgrade += credits * check(grade);
            }
            Console.WriteLine("Totolcredits; {0}", Totolcredits);
            Console.WriteLine("Totolcgrade; {0}", Totolcgrade);
            double GPA = Totolcgrade / Totolcredits;
            Console.WriteLine("Your GPA is: {0}", GPA);
        }
        static double check( string grade)
        {
            if (grade=="A")
            {
                return 4.0;
            }
           else if (grade == "B+")
            {
                return 3.5;
            }
            else if (grade == "B")
            {
                return 3.0;
            }
            else if (grade == "C+")
            {
                return 2.5;
            }
            else if (grade == "C")
            {
                return 2.0;
            }
            else if (grade == "D+")
            {
                return 1.5;
            }
            else if (grade == "D")
            {
                return 1.0;
            }
            else if (grade == "F")
            {
                return 0;
            }
            else 
            {
                return 0;
            }
        }
       
    }
}  

