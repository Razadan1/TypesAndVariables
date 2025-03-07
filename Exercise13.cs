using System;

namespace TypesAndVariables
{
    public class Exercise13
    {
        // // // 13. Declare two variables of type int. Assign to them values 5 and 10 
        // // // respectively. Exchange (swap) their values and print them.
        public void solveExercise13()
        {
            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine($"Before swap\na = {a} \n b = {b}");

            c = a;
            a = b;
            b = c;
            Console.WriteLine($" After being swapped\na = {a} \n b = {b}");

        }
    }
}