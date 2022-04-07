

namespace MyFirstApplication;

internal class Exercise3
{
    /*
    Problem 1 - Write a method that takes 1 int arguement and an int return type.
    Utilize the modulus operator to complete this task. Assign the data
    values below to their own variables. Use the Console WriteLine statement
    on the first 4 variables listed below and calculate the modulus
    with the passed in arguement parameter. Using the last variable below, calculate
    the modulus with the passed in arguement parameter and return it

    */

    public void ModulusExercise(int value)
    {
        int total = 15 % value;
        int total1 = 456 % value;
        int total2 = 23 % value;
        int total3 = 89 % value;
        Console.WriteLine(total);
        Console.WriteLine(total1);
        Console.WriteLine(total2);
        Console.WriteLine(total3);
        Console.WriteLine(+245);

    }

    /* 
     Problem 2 - Write a method that takes no arguements and a void return type
    Utilizing the math problem in this task, fill in any missing pieces to get the output.
    10 + 32*12/3. Write a ConsoleLine to solve each output.
      
   
     */

    public void MathProblem()
    {
        int val1 = 10, val2 = 32, val3 = 12, val4 = 3;

        int total1 = val1 + val2;

    }

    /* Problem 3- Write a method that takes two short type arguements and a void
     return type. Using the Compound Assignment operators below, use 
    the first arguement parameter as the left operand to get the result.
    Print each one using Console Writeling statement.
     
     */

    public void CompoundAssignmentExercise(int value1, int value2)
    {
        value1 += value2;
        Console.WriteLine(value1);
        value1 /= value2;
        Console.WriteLine(value1);
        value1 *= value2;
        Console.WriteLine(value1);
        value1 %= value2;
        Console.WriteLine(value1);
        
        
    }
    
    /* Problem 4 - Write a method that takes two bool type arguements
     and a void return type. Using Boolean Logical operators &,|,^ and ||
    to complete this task. Use a Console WriteLine statement to calculate
    each result using the operators. The second arguement is the left
    operand. Use the below values when testing your method. Using 
    comments, provide your output results inside the method after your
    statements.
 */

    public void BooleanLogical(bool arg, bool arg2)
    {
        // And 
        Console.WriteLine(arg & arg2);
        // Or
        Console.WriteLine(arg | arg2);
        // Exclusive Or
        Console.WriteLine(arg ^ arg2);
        // ||
        Console.WriteLine(44 > 55 || 22 < 90);
        /* Output results for true,false 
         And = false, Or = true, Exclusive Or = true, || = true
        
           Output results for false, false
        And = false, Or = false, Exclusive Or = false, || = true
       
           Output results for true/true 
        And = true, Or = true, Exclusive Or = false, || = true
          
          Output results for false/true

        And = false, Or = true, Exclusive Or = true, || = true
          

         
        */
    }



}
