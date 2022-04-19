namespace MyFirstApplication;
// Exercise 13 - Abstract class & Properties 




/*
 Problem 1 - In your exercise13.cs file, change your class to an interface and name
it IMovement.This Interface will have 1 property. The property will have
an int and called Speed. It will have a get and init. 
 
 */
public interface IMovement
{
    int Speed { get; set; }

}
/*
 Problem 2 - Under the interface you will create an Abstract class called Waterbirds. This abstract class
will implement the Imovement interface. The interface property should be implemented
in the abstract classs as an abstract property. Create two abstract methods for the abstract
class that is related to WaterBirds. Create constructor that will take an int parameter
and be assigned to the speed property.
*/
internal abstract class WaterBirds : IMovement
{
    protected int num;

    protected abstract int Inches { get; }
    protected abstract int Feet { get; }


    public abstract int Speed { get; }

    protected WaterBirds (int num)
    {
        this.num = num;
    }

    public abstract int BirdLength();
    public abstract int BirdHeight();

}
/*
 Problem 3 - Under the abstract class WaterBirds, create a derived class that will extend the WaterBirds
class. Implement the abstract methods and property. Use Console Writeline statements in your
methods that provide information related to the methods. One of them should use an interpolation
string and consume the speed property. Create a constructor that will take an int parameter
and use the :base() to pass the int value back to the base abstract class.
 */
internal class WaterBirdsDerived : WaterBirds
{
    protected override int Inches { get; } = 12;

    protected override int Feet { get; } = 2;

    public override int Speed { get; } = 15;

    public WaterBirdsDerived(int value)
        : base(value) { }

    public override int BirdHeight(int speed)
    {
        Console.WriteLine($"The taller the bird is the less {speed} it will have");
    }

    public override int BirdLength()
    {
        return num * Inches;
    }
}


