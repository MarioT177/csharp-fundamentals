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
// Lesson2Example();
// Lesson3Example();
// Lesson4Example();
// Lesson5Example();Lesson6Example();

Lesson7Example();

void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly struct 
    Student myStudent = new Student(15, "Mario");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    Console.WriteLine(res);


}








void Lesson6Example()
{
    // default Constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size{myLessonHats.HatSize}");




    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;

    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);


    Console.WriteLine();
    // Mult - cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");



}

Exercise6();
void Exercise6()
{
    Exercise6 myShoes = new Exercise6("Nikes", 10);
    Console.WriteLine(myShoes.ShoeSize);
    myShoes.ShoeSize = 9;



}






// Lesson 5 Expressions & Pattern Matching
void Lesson5Example()
{
   Lesson5 myLesson5 = new Lesson5();

    // Call Method of myLesson5
    myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    handler("Hello CSharp");

    // Func delagate
    Func<int, int> add = myLesson5.Sum;
    Console.WriteLine($"func example = {add(23)}");

    // Lambda Expression
    myLesson5.LambdaGreeting();
    myLesson5.LambdaGreeting();

    // Switch Expressions
    string value1 = myLesson5.BasicSwitch("red");
    Console.WriteLine(value1);
    string value2 = myLesson5.FavoriteColor("green");
    Console.WriteLine(value2);
    // Relational pattern
    myLesson5.DrinkSize(33);
    // Logical Patterns
    myLesson5.TemperatureGuide(48.6);
    myLesson5.NumberChoice(3);
}





// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(12);
    // myLesson4.BasicIfElseStatement(15);
    // myLesson4.BasicIfElseChainStatement(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(25));
    // myLesson4.BasicSwitchStatement(2);
    // myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    myLesson4.BasicJumpStatement();



}





// Lesson 3 Operators and overflow checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    //int alpha = 2147483647;
    //int total = alpha + 10;
    // Console.WriteLine(total);
    // -2147483639
    //myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    // myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    myLesson3.MyIncrDecrExample();
}

Exercise3Ex();

void Exercise3Ex()
{
    Exercise3 myExercise3 = new Exercise3();
    myExercise3.ModulusExercise(800);
    myExercise3.CompoundAssignmentExercise(12, 35);
    myExercise3.BooleanLogical(true, false);
    myExercise3.BooleanLogical(false, false);
    myExercise3.BooleanLogical(true, true);
    myExercise3.BooleanLogical(false, true);


}











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

ExerciseTwoLab();

void ExerciseTwoLab()
{
    
    
    
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.myEscapeSequence();
    Console.WriteLine(myExercise2.myEscapeSequence());
    myExercise2.MyExampleChar1();
    Console.WriteLine(myExercise2.MyInterpolationProblem("Mario", "300", "Snickers", "Lemonade"));

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