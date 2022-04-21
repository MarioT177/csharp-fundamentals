namespace MyFirstApplication;
// Exercise 17 - Exception Handling 



/*
 Problem 1 - Write a method that has two int parameters and no return type. You will
use a try/catch for this method. Create a division problem in the try block.
THe catch will utilize the DivideByZeroException. Provide a Console
Writeline message for both the try block and catch block. The one in the
tryblock should display the answer to the division problem. The one in the 
catch block should have a message using interpolation along with a variable
.Message syntax. Test the method with different numbers, including 0 so you can 
ensure the catch executes.
 
 */
internal class Exercise17
{
    public void TryProblem()
    {
        int number1 = 100;
        int number2 = 0;
        try
        {
            Console.WriteLine(number1 / number2);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Anything divide by 0 is 0 {ex.Message}");
        }


    
    }

/*
 Problem 2 - Write a method that has a horse parameter and no return type. Using and if 
statement, determine if your horse is null. If if is null, use the 
throw keyword and a message to indicate it is a null. If the horse is not
null, use a Console WriteLine statement to print out one of your horse
properties.
 
 */

public void HorseExample(Horse horse)
    {
        if (horse == null)
        {
            throw new NullReferenceException("Horse is null");
        }
        else
        {
            Console.WriteLine(horse.HorseType);
        }


    }




}
