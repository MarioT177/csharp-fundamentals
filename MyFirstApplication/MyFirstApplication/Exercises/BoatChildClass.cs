namespace MyFirstApplication;

public class ChildBoat
{
    private string _rowBoat;


    public string RowBoat
    {
        get => _rowBoat;
        set => _rowBoat = value;
    }


    public ChildBoat()
       : this("Small", " Fast")
    { }

    public ChildBoat(string anchorSize, string boatType, string rowBoat)
        : this(anchorSize, boatType, "Tug boat", "Small")
    { }

    public ChildBoat(string anchorSize, string boatColor, string boatType, string rowBoat )
    
        :base (anchorSize, boatColor, boatType, rowBoat);
    { }

public void ChildBoatType()
{
    Console.WriteLine($"A  is a {rowBoat} version of a Boat");
}

}
