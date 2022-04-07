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
Lesson3Example();




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