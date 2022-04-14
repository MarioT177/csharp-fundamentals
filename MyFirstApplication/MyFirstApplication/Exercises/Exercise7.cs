

namespace MyFirstApplication;

 // Exercise 7 Records & Structs

// This lab goes over structs and how to build records for different uses.
 


internal struct Employee
/*  Problem 1 - Change the type from class to struct. Change the name of the struct
 from Exercise7 to Employee. The filename should not be changed.
Create 2 struct variables. The first one will be of type int  and be named
_id. The second variable shoould be of type string and be named _name.Create
a constructor that takes 2 arguements, with the first being an int and 
the second a string. The struct variable should be assigned to the constructor
parameters. Create properties for these 2 variables.
 
 */



{
    private int _id;
    private string _name;

    public int EmployeeId
    {
        get { return _id; }
        set { _id = value; }
    }

    public string EmployeeName
    {
        get { return _name; }
        set { _name = value; }
    }

    public Employee(int EmployeeId, string EmployeeName)
    {

        _id = EmployeeId;
        _name = EmployeeName;
    }

   /*
    Problem 2 - Create a Record based on your Boat object from the Object Oriented
   Programming lesson. In your record body, including the boat method that you defined
   This record can be in the same file as exercise1. Just put the code
   under it as seen in the lecture. Test your code to ensure it is working
   correctly
    */

    internal record Boat(string paintColor, string WindowType);

    public record struct WindowSize(int width, int height)
    {

        public void CalculateSize()
        {
            Console.WriteLine(width * height);
        }


    }


} // end struct 
