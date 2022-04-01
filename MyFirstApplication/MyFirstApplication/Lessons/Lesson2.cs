namespace MyFirstApplication;

/*
 This class goes over strings
 */

internal class Lesson2
{
    string myString = "Hello World";

    // String Method - Trim
    public void MyTrimExample()
    {
        string str = " World ";
         //before trim
            Console.WriteLine(str);
        // trim
        string myTrim = str.Trim();
        // after trim
        Console.WriteLine(myTrim);

    }
    // String method - Equals
    public void MyEqualExample(string beta)
    {
        Console.WriteLine(beta.Equals("World"));
    }

    // String Methods ToUpper and ToLower
    public void MyUpperLowerExample()
    {
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());
    }

    // String Method - Length 
    public int MyStringLength()
    {
        return myString.Length;

    }

    // Char - Uses single quotes
    public void MyExampleChar()
    {
        char myChar = 't';
        char copywright = '\u00A9';
        char something = '\x00A9';
        Console.WriteLine(myChar);
        Console.WriteLine(copywright);
        Console.WriteLine(something);
    }

    // Escape Sequence
    public string MyEscapeExample()
    {
        return "That\'s a cool car. \tcan I \ndrive it sometime?";
    }

    // Concatenation -with 2 string parameters

    public void MyJoinedStrings(string values1, string value2)
    {
        Console.WriteLine(values1 + " " + value2);
    }

    // String Interpolation
    public string MyInterpolationExample(string food, int amount)
    {
        return $"My faorite food is {food} and I ate {amount} servings of it.";
    }

    public void MyOtherInterpolation()
    {
        Console.WriteLine($"|{"Number",-10} | {"Order",15}|");

    }

} // end class
