using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment


/*
 Multi-line comment
The below statement is a local function. Local functions
are inside of members and are private by defualt. This means
They are specific to that member and can only be called inside
that member.
 */

// Lesson Examples
// HouseExample();
// Lesson1Example();
Lesson2Example();

// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine (myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("Pizza", 3));
    myLesson2.MyOtherInterpolation();
}

void HouseExample()
{
House myHouse = new House();
myHouse.DoorOpenClose();
}

/*
 This local function is for my first lab exercise
*/
FirstLocalFunctionExample();

void FirstLocalFunctionExample()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to C Sharp");
    Console.WriteLine("This C sharp course is cool");
    Console.WriteLine("I am learning stuff everyday");
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();

}