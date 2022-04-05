

namespace MyFirstApplication;

internal class Exercise2
{
    /* Problem 1- write a method that takes a string arguement parameter and void return type. Using string concatenation
         * and the below string concatenation and the below string methods, write string methods,
         * write a console writeline statement for each of them. Inside the string 
         * concatenation will be the name of each string method. When testing
         * this method use the following string "exercise two lab"
         */

    
 public void ExerciseTwoLab(string value1)
    {
         Console.WriteLine("Trim() "+value1.Trim());
         Console.WriteLine("ToLower() "+value1.ToLower());
         Console.WriteLine("Contains() "+ value1.Contains("tow"));
         Console.WriteLine("Length" + value1.Length);
         Console.WriteLine("IndexOf() " + value1.IndexOf('c'));

    }
    

    /* Problem 2 - Write a method that takes no arguements and void return type
     * Using the unicode resource link, assign the Unicode value of the 
     * Pilcrow Sign to a variable. Use the Console WriteLine to print the 
     * variable. This variable should utilize the type that takes 1 character. 
     
     
     
     */
    public void MyExampleChar1()
    {

        char Pilcrow = '\u00B6';
        Console.WriteLine(Pilcrow);

    }


    /* Problem 3 - Write a method that takes no arguments and a void 
     return type. Use 1 string variable and 1 Console WriteLine to
    complete this task.Use escape sequences to achieve the below results
     
    */

    public string myEscapeSequence()
    {
        return "Jack and Jill\n Went up a hill\n To fetch a pail of water\n Jack fell down and broke his crown\n and jill came tumbling after\n";
    }

    /* Problem 4 - write a method that takes no arguements but does have a string return type.
     you will utilize interpolation to complete this task. Create variables
    for each provided below. Using interpolation return a string that includes
    the variables in a sentence.
     */

    public string MyInterpolationProblem(string name, string movie, string snack, string drink)
    {
        return $"My name is {name}, my favorite movie is {movie} my favorite snack and drink are {snack} and {drink}";

    }


}
