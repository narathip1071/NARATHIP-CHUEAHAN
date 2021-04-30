using System;

namespace การบ้าน4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String halfDNASequence;
            

            do
            {   halfDNASequence = Console.ReadLine();
                IsValidSequence(halfDNASequence);
                {
                    if (IsValidSequence(halfDNASequence) == true)
                    {
                        Console.WriteLine("Current half DNA sequence : {0} ", halfDNASequence);
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        char C = char.Parse(Console.ReadLine());
                        ReplicateSeqeunce(halfDNASequence);
                        checkc(ref C, ReplicateSeqeunce(halfDNASequence));
                    }

                    else
                    {
                        Console.WriteLine("That half DNA sequence is invalid.");
                    }
                }
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                char F = char.Parse(Console.ReadLine());
                if (F != 'Y')
                {
                    checkf(ref F);
                }
                else
                {
                    halfDNASequence = Console.ReadLine();
                }
            } while (halfDNASequence != "0");
           
            
        }

        static void checkc(ref char C,string DNA)
        {

            if (C == 'Y')
            {
                Console.WriteLine("Replicated half DNA sequence :{0}", DNA);
            }
            else if (C == 'N')
            {
                Console.WriteLine();
            }
            else
            {
                do
                {
                    Console.WriteLine("Please input Y or N.");
                    C = char.Parse(Console.ReadLine());
                     
                } while (C != 'Y' && C != 'N');
                checkc(ref C, DNA);
            }


        }


        static void checkf(ref char F)
        {

             if (F == 'N')
             {
                Console.WriteLine();
             }
            else 
            {
                do
                {
                    Console.WriteLine("Please input Y or N.");
                    F = char.Parse(Console.ReadLine());
                } while (F != 'Y' && F != 'N');
                checkf(ref F); 
            }
            
        }
        static bool IsValidSequence(string halfDNASequence)
        {

            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;

                }
            }
            return true;


        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {

            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;

        }
       

    }
}
