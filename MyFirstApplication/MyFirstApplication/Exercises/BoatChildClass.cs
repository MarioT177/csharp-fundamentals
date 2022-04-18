namespace MyFirstApplication;

internal class RowBoat: Boat
{
    private string _rowboatSize;


    public string RowBoatSize
    {
        get => _rowboatSize;
        set => _rowboatSize = value;
    }


    public RowBoat(string rowBoat)
       : this("Small", " Fast", rowBoat)
    { }

    public RowBoat(string anchorSize, string boatColor, string rowBoat)
        : this(anchorSize, boatColor, "Large",20, rowBoat)
    { }

    public RowBoat(string anchorSize, string boatColor, string boatType, int boatLength, string rowboatSize )
        :base (anchorSize, boatColor, boatType, boatLength)
      { 
        _rowboatSize = rowboatSize;
      }

public void ChildBoatType()
{
    Console.WriteLine($"A  is a {_rowboatSize} version of a Boat");
}

}

/* Lesson 12 problem 4 - In your child class of Boat, using the 
 override keyword create a method that has the same name as the 
virtual method from Boat.Add a Console WriteLine that provides
a different message from Boat.
 */
internal class RowBoatt : Boat
{
    public override void BoatMake()
    {
        Console.WriteLine($"Different boat makes are used for different jobs");
    }
}
