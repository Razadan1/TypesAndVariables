using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypesAndVariables.obj
{
    public class Exercise8
    {
        // // 8. Declare two variables of type string and give them values "Hello" and 
        // // "World". Assign the value obtained by the concatenation of the two 
        // // variables of type string (do not miss the space in the middle) to a 
        // // variable of type object. Declare a third variable of type string and 
        // // initialize it with the value of the variable of type object (you should use 
        // // type casting). 
        // // 136  
        // // Fundamentals of Computer Programming with C#
        public void solveExercise8()
        {
            string str1 = "Hello" + " " + "World";
            var obj = str1;
            string str2 = obj;
            
        }
    }
}