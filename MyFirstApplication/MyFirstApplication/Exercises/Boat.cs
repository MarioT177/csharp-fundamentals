

namespace MyFirstApplication;

// Exercise 10 Encapsulation 
// This lab goes over encapsulation 


internal class Boat

/*
 Problem 2 - Create a class based on your Boat object. You will follow the same
instructions as exercise 1 except for the following. Include your attributes
as Expression Body Definition Properties.
 
 */



{
    private string _anchorSize;
    private string _boatColor;
    private string _boatType;
    private int boatLength;

    public string AnchorSize
    {
        get => _anchorSize;
        set => _anchorSize = value;
    }

    public string BoatColor
    {
        get => _boatColor;
        set => _boatColor = value;
    }

    public string BoatType
    {
        get => _boatType;
        set => _boatType = value;
    }

    public int BoatLength
    {
        get => boatLength;
        set => boatLength = value;

    }

    public Boat() 
        :this("white", "medium")
    { }


    public Boat(string paintColor, string anchorSize)
        : this(paintColor, anchorSize, "White", 20)
    { }


    public Boat(string anchorSize, string boatColor, string boatType, int boatLength)
    {
        AnchorSize = anchorSize;
        BoatColor = boatColor;
        BoatType = boatType;
        BoatLength = boatLength;    
    }

/* lesson 12 - Problem 3 In your boat class, add the virtual keyword
 to your method created in Lesson 10. Create a second version of the same
method and add a parameter. Include a Console Writeline method in the new
that uses the parameter. This parameter needs to be based on one of your
properties */

public virtual void BoatMake()
    {
        Console.WriteLine($"The {BoatType} is a tug boat");
    }

    public void BoatDuty()
    {
        Console.WriteLine($"Different size boats are used for different jobs, {boatLength} are used to transport goods");
    }


}






