using System;

namespace TypesAndVariables
{
    public class Exercise12
    {
        // 12. A company dealing with marketing wants to keep a data record of its 
// // // employees. Each record should have the following characteristic – first 
// // // name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
// // // (27560000 to 27569999). Declare appropriate variables needed to 
// // // maintain the information for an employee by using the appropriate data 
// // // types and attribute names. 
        public void solveExercise12()
        {
            string firstname = "Your Name";
            string lastname = "Your Surname";
            int? age = 23;
            char gender = 'm';
            double? employeenumber = 08123456789;

            Console.WriteLine($"Fill in the details:\n FirstName: {firstname}\nLastName: {lastname}\nAge: {age}\nGender:{gender}\nGender:{employeenumber}");
        }
    }
}
