

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
public void BoatMake()
    {
        Console.WriteLine($"The {BoatType} is a tug boat");
    }

}






