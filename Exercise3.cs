using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Exercise3
    {
        // 3. Write a program, which compares correctly two real numbers with 
        // accuracy at least 0.000001. 

        public void solveExercise3()
        {
            Console.WriteLine("Enter  a number to compare: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter  the second number to compare: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a + " is greater than " + b);
            }
            else if (a == b)
            {
                Console.WriteLine(a  + " is equal to " + b);

            }
            else
            {
                Console.WriteLine(a + " is less than " + b);
            }
        }

    }
}