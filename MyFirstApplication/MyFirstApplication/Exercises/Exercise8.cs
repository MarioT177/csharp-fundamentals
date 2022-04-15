
namespace MyFirstApplication;
 
// Exercise 8 - This lab goes over static fields and methods


internal class Exercise8
{
    /*
Problem 1 - Write a constants at the class level. The constnat should be foot with a 
value of 12 to represent the number of inches in a foot. Write a method
that takes 1 int parameter and a void return type. This method will convert
feet to inches. The formula that you would use will be the parameter * foot.
Your parameter will represent the number of feet to convert to inches.
Using a console writeline statement, print the results. Test your method
using the number 3 to see if you get 36.
 
 */
    public const int Feet = 12;
    public const int Inches = 1;

    public const double InchesInAFoot = (double) Inches / (double) Feet;
    
    public static int FeetInches;
    private int _inches;

    private static int CalculateFeetInches()
    {
        return ++FeetInches;
    }

    public void CalculateInches()
    {
        int total = Feet * _inches;
        Console.WriteLine($"The number of {Feet} to convert to {_inches}");
    }

    /*
     Problem 2- Write a static method that takes 2 int parameters and a void return type
    This method will be used to calculate the length and width of a rectagle/square.
    This formula is length X Width. The first parameter should represent the 
    length and second parameter should be the width. Using a console writeline statement
    ,print the results.Test your method and add what you used to test as a comment either before
    the method or after.


     */
    public static int Area;
    private int _square;
    private int _rectangle;


private static int CalculateArea()
    {
        return ++Area;
    }

public void Problem2()
    {
        int total = _square * _rectangle;
        Console.WriteLine($"{_square} times {_rectangle} equals {Area}");
        CalculateArea();
    }
    /*
     Exercise8.Area = 24;
    myExercise.CalculateArea();
    Exercise8.Problem2();
    Console.WriteLine($The calulation has been done{Exercise8.Area} tiems")
     
     */
}



