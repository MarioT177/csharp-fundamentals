namespace MyFirstApplication;


// Exercise 10 Encapsulation 
// This lab goes over encapsulation


internal class Horse
/*Problem 1 - Create a class based on your Horse object. Include your attributes as auto properties.
  Create 3 constructors. The first constructor should have parameters equal to your properties.
  Assign each parameter to your properties. The second constructor should have 
  2 parameters. Using the :this() keyword, you will pass your information to your first constructor,you 
  will create the defualt constructor. Using the :this() keyword, you will pass
  2 defualt values in that will pass to the 2nd constructor. Also include in the class
  your method for Horse.
 
 */




{
    public string HorseColor { get; set; }
    public string TailLength { get; set; }
    public string HorseType { get; set; }
    public int HorseWieght { get; set; }


    public Horse()
        :this("white", "long")
        { }


    public Horse(string horseColor, string tailLength)
        :this(horseColor, tailLength, "Mustang", 20)
        { }


    public Horse(string horseColor, string tailLength, string horseType, int horseWeight)
    {
        HorseColor = horseColor;
        TailLength = tailLength;
        HorseType = horseType;
        HorseWieght = horseWeight;

    }
/*
Lesson 12 - Problem1 -  In your Horse class, add the virtual keyword to your method created in Lesson 10.Create
a second version of the same method and add a parameter. Include a Console Writeline method
and add a parameter. Include a Console Writeline method in the new method that uses the parameter
This parameter needs to be based on one of your propertes. 
 
 */
    public virtual void HorseSpecies()
    {
        Console.WriteLine($"My horse is a {HorseType}");
    }
   
    public void HorseSpeciesColor()
    {
        Console.WriteLine($"I have a black {HorseColor} mustang");
    }

}


