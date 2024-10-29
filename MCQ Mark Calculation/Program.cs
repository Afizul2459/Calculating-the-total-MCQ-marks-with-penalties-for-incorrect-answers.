using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ_Mark_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            double n,t;

            Console.Write("Enter the total MCQ = ");
            x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(x);

            Console.Write("Enter the MCQ Currect Answer = ");
            y = Convert.ToInt32(Console.ReadLine());

            if (y > x)
            {
                Console.WriteLine("Correct answers cannot exceed the total number of questions. Please try again.");
                return;
            }

            // MCQ wrong answer
            z = x - y;
            // Penalty for each wrong answer
            n = z * 0.25;

            // MCQ Total Mark
            t = y - n;

            Console.WriteLine("MCQ Total Mark : " + t);


        }
    }
}
