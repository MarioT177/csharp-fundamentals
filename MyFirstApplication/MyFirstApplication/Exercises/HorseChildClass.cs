

namespace MyFirstApplication;
/*
 Create a child class based on your Horse object. Include one child attribute as an 
auto property. Create 3 constructors. The first constructor should have 4 parameters with 
3 of them from Horse and your child property. Using the keyword:Base(), you will 
put the four horse parameters in the parenthesis. In the body of the constructor you 
will assign your child parameters to your property.

The second constructor should have 2 parameters, 2 based on the horse and 1 from
your child. Using the :this() keyword, you will pass 2 of the parent attributes 
and your child attribute information to the first constructor. Include defualt values
to represent the 2 remaining horse parameters.

For the last constructor, you will create the defualt constructor. Using the 
:this() keyword, you will pass 2 defualt values in that will pass the 2nd constructor.
Also include in your class, your method for your child class
 
 
 */
public class Pony
{
    protected string PonySize { get; set; }

    public Pony()
        : this("Small", "Brown")
    { }



    public Pony(string horseColor, string tailLength, string PonySize)
        : this(horseColor, tailLength, "Mustang", 20, "Small")
    { }




    public Pony(string horseColor, string tailLength, string horseType, string ponySize)

         :base(horseColor, tailLength, horseType, ponySize)
    { 
          PonySize = ponySize;
    }

    public void PonySpecies()
    {
        Console.WriteLine($"A pony is a {PonySize} version of a Horse");
    }





}// end class
