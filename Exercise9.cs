using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypesAndVariables.obj
{
    public class Exercise9
    {
        // // 9. Declare two variables of type string and assign them a value “The 
        // // "use" of quotations causes difficulties.” (without the outer quotes). 
        // // In one of the variables use quoted string and in the other do not use it.
        public void solveExercise9()
        {
            string str = "The \"use\" of quotations causes difficulties.";
            string str2 = "The 'use' of quotations causes difficulties.";
            Console.WriteLine($"The use of double quoted string: {str} \n The use of single quoted string: {str2}");
        }
    }
}