

namespace MyFirstApplication;

internal class Exercise6
{

    // Delegates for problem 3 
    public delegate void TryOn(string type);






    /* Problem 1 - Write a constructor for your exercise file that takes 2 parameters
      The first parameter should have an int type and a variable name of showSize.
      The second parameter should have a string type and a variable name of 
      shoeType. Create private class variables for these types and use an
      underscore when defining them. Inside the constructor associate the class
      variable with the constructor parameters.
     
     */

    // private class variables
    private string _shoeType;
    private int _shoeSize;

    // propeties 
    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    public int ShoeSize
    {
        get { return _shoeSize; } 
        set { _shoeSize = value; }
    }

     public Exercise6(string type, int size)
    {
        _shoeType = type;
        _shoeSize = size;
    }

    /* Problem 2 - Write the properties for the class variables defined in 
      exercise 1. Ensure they are labled as public and are spelled using
      capital letter. 
     */


    /*
      Problem 3 - Write a delegate that takes a string parameter. This delegate should be
    named TryOn.Write a method that takes a string arguement and a void 
    return type. In the method body include a Console WriteLine statement
    that will print the message. Test your Delegate in Program.cs to ensure
    everything works properly. Using multi-line comment on your Exercise6.cs file
    provvide the info you used to test the delegate.
      
      
     */

    // Methods for problem 3 

    public void TryOnHat(string message)
    {
        Console.WriteLine($"TryOn = {message}");
    }

/* Testing method 
Exercise6 myExercise6 = new Exercise6();
Exercise6. TryOn theHat = myExercise6.TryOnHat
    */ 
} // end class
