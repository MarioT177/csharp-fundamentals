

namespace MyFirstApplication;

internal class Exercise5
{
    /*
     Problem - 1  Write a method that takes 2 int parameters and an int return type.
    Using the formula below from Ohm's law, determind the voltage. The first
    method parameter will represent current and the second parameter will 
    represent resistance. Using the Func<int,int,int> and a lambda expression
    ,determine the voltage calculation and return the value.
    */
    public int OhmsLaw(int current, int resistance)
    {
        Func<int, int, int> square = (cur, res) => cur * res;
 
        int voltage = square(current, resistance);
     
        return voltage;
    }

    /* 
     Problem 2 - Write a method that will take 1 char parameter and 
    string return type. Using a switch expression and the table below,
    return the description. If the value does not match the grade, return
    the defualt message, "Not a valid grade".
    */
    public string Grades(char able)
    {
        string result = able switch
        {
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Good",
            'A' => "Average",
            'F' => "Fail",
             _   => "Not a valid grade"

        };
        return result;
    }
    /*
     Problem 3 - Write a method that takes 1 arguement and a void return type
    Using a Relational Pattern and switch expression determine a size of
    popcorn based on the table below and using a Console WriteLine, print 
    the popcorn size.
     */

    public void Popcorn(int size)
    {
        string result = size switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie snack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
                _  => "We dont have that size"
        };
        Console.WriteLine(result);

    }

}
