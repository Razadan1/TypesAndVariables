using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Exercise5
    {
    //         5. Declare a variable of type char and assign it as a value the character, 
    // which has Unicode code, 72 (use the Windows calculator in order to find 
    // hexadecimal representation of 72). 

    public void solveExercise5()
    {
        char ans = (char) 0x41;

        Console.Write(ans);
    }
    }
}