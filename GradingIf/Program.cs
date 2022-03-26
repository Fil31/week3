using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam result");
            char userInPut = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userInPut == 'A')
            {
                Console.WriteLine("Outstanding");
            }
            else if (userInPut == 'B')
            {
                Console.WriteLine("Superior");
            }
            else if (userInPut == 'C')
            {
                Console.WriteLine("Good");
            }
            else if (userInPut == 'D')
            {
                Console.WriteLine("Satisfactory");
            }
            else if (userInPut == 'E')
            {
                Console.WriteLine("Low Pass");
            }
            else if (userInPut == 'F')
            {
                Console.WriteLine("Failure");
            }
            else
            {
                Console.WriteLine("This is not an exam result");
            }
        }
    }
    // Результат экзамена от A до F.
    // A - outstanding B - Superior C - Good D - Satisfactory E - Low Pass F - Failure 
}
