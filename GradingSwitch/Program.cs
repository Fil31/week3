using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam result");
            char userInPut = Convert.ToChar(Console.ReadLine().ToUpper());
            switch(userInPut)
            {
                case 'A':
                    Console.WriteLine("Outstanding!");
                    break;
                case 'B':
                    Console.WriteLine("Superior");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Satisfactory");
                    break;
                case 'E':
                    Console.WriteLine("Low pass");
                    break;
                case 'F':
                    Console.WriteLine("Failure");
                    break;
            }
        }
        // Результат экзамена от A до F.
        // A - outstanding B - Superior C - Good D - Satisfactory E - Low Pass F - Failure 
    }
}
