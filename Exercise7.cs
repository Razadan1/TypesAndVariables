using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypesAndVariables.obj
{
    public class Excercise7
    {
        // // 7. Declare two variables of type string with values "Hello" and "World". 
        // // Declare a variable of type object. Assign the value obtained of 
        // // concatenation of the two string variables (add space if necessary) to this 
        // // variable. Print the variable of type object. 

        public void solveExercise7()
        {
            string str1 = "Hello" + " " +"World";

            var obj =  str1;

            Console.WriteLine(obj);
        }
    }
}