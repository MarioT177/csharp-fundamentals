

namespace MyFirstApplication;

internal class Exercise14
{
    public void ExerciseSingleArray()
    {

        string[] singleArray = new string[3];
        singleArray[0] = "mint choclate";
        singleArray[1] = "rocky road";
        singleArray[2] = "sherbert";

        foreach (string icecream in singleArray)
        {
            Console.WriteLine($"my favorite {icecream} flavor is mint choclate");

        }

    }
    public void FootballArray()
    {
        int[,] footballScore = new int[0, 0];
        footballScore[6, 3] = 1;
        footballScore[13, 0] = 2;
        footballScore[3, 7] = 3;
        footballScore[0, 7] = 4;
        footballScore[17, 22] = 5;
        foreach (int finalscore in footballScore)
        {
            Console.Write($"{finalscore}, ");
        }



    }


}
