namespace MyFirstApplication.Exercises;

internal class Exercise1
{

    /* Problem 1 - Write out a method with no arguments and a void return type that will
    print the output of the number 35 based on the number systems below.
    The values should be assigned to a variable inside the method prior to
    printing them using Console WriteLine */ 

    public void ProblemOne()
    {
        // value of 35
        int value1 = 35; // decimal
        int value2 = 0x23;// hexadecimal 
        int value3 = 0b100011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    // Problem #2 

    byte alpha = 33;
    short beta = 4534;
    int charlie = 345344;


    public void ProblemTwo(byte alpha, short beta, int charlie)
    {
        int someValue = alpha;
        long someValue2 = beta;
        float someValue3 = charlie;
        Console.WriteLine(someValue);
        Console.WriteLine(someValue2);
        Console.WriteLine(someValue3);
    }
    // Problem #3 

    double bravo = 12.30D;
    float delta = -5.5F;
    long echo = 2345L;

    public void ProblemThree(double bravo, float delta, long echo)
    {
        long converted = (long)bravo;
        int converted1 = (int)delta;
        short converted2 = (short)echo;
        Console.WriteLine(converted);
        Console.WriteLine(converted1);
        Console.WriteLine(converted2);
    }

    //* Problem #4

    public void ProblemFour()
    {
        decimal value1 = 123456_987;
        long value2 = -9516248;
        ushort value3 = 3500;
        uint value4 = 988562486;
        float value5 = -19733_14895;
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
        Console.WriteLine(value4);
        Console.WriteLine(value5);
    }



}
