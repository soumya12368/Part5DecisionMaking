using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Enter your exam score as a percentage: ");//  input the exam score as a percentage
            double userScore = Convert.ToDouble(Console.ReadLine()); 
            if (userScore >= 90)// Use if-else statement to determine and display the letter grade
            {
                Console.WriteLine("Your letter grade is: A+");
            }
            else if (userScore >= 80)
            {
                Console.WriteLine("Your letter grade is: A");
            }
            else if (userScore >= 70)
            {
                Console.WriteLine("Your letter grade is: B+");
            }
            else if (userScore >= 60)
            {
                Console.WriteLine("Your letter grade is: B");
            }
            else
            {
                Console.WriteLine("Your letter grade is: F");
            }
        }
    }
}
