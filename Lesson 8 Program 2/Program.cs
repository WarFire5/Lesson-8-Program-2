using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B, result, otherResult;

            Console.WriteLine("Введите число 'A':");
            A = Console.ReadLine();

            Console.WriteLine("Введите число 'B':");
            B = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int difference = a - b;

            int otherDifference = b - a;

            result = "A > B на" + " " + difference;

            otherResult = "B > A на" + " " + otherDifference;

            if (a > b)
            {
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine(otherResult);
            }

            Console.ReadLine();

        }
    }
}
