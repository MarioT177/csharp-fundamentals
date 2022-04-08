

namespace MyFirstApplication;

internal class Exercise4

/*
 problem 1 - Write a method that takes 2 string arguments and void 
return type. Using and if-else statement, compare the two strings to each other
Using a Console WriteLine statement, print out the results of whether 
the strings are equal. Provide a comment inside the method that says what strings
you used during testing
 */

{
     public void IfElseProblem(string able, string beta)
    {
        if(able == beta)
        {
            Console.WriteLine($"{able} is equal to {beta} ");
        }
        else
        {
            Console.WriteLine($"{able} is greater than {beta}");
        }
        
   }

/* problem 2 - Write a method that will take 1 char arguement and 
 a string return type.Using a switch and the table below, return the 
description. If the value does not match the grade, return the defualt 
message, "Not a valid grade"

 */

    public void SwitchProblem(char A)
    {
        switch (A)
        {
            case 1:
                Console.WriteLine($"{V} is a not vaid grade");
                break;
            case 2:
                Console.WriteLine($"{E} is not a valid grade");
                break;
            case 3:
                Console.WriteLine($"{G} is not a valid grade");
                break;
            case 4:
                Console.WriteLine($"{F} is not a valid grade");
                break;
            default:
                Console.WriteLine($"{A} is a valid grade");


        }



    }

    /*
           problem 3 - Write a method that takes no arguements and a void
        return type. Using an iteration statement, display all the numbers divisble
        by 3 from 0 to 30.Utilize a modulus to obtain your results. 
         */

    public void BasicForStatement()
    {
        for (int i = 0; i < 30; i++)
        {
            while (i % 3 == 0)
            {
                if (i % 3 == 0)
                {

                }
            }
        }
    }





}
