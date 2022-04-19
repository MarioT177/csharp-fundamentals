namespace MyFirstApplication;
// Lesson 15 Enums & Tuples


/*
 Problem 1 - Above the class, write an enum called Favorite Movies. Add your own favorite movies
to the enum. Write a method that has a string return type and an enum parameter. This enum parameter
will be your favorite movie enum. Write a switch expression that takes the enum and
prints out a string return. Using string interpolation in your return message that includes
the name of the movie chosen.
 
 */
public enum Movies {StarWars, Intersteller, Prometheus, Alien }
internal class Exercise15
{
     public string  myFavorite(Movies favorite)
    {
        string message = favorite switch
        {
            Movies.StarWars => $"My favorite movie is {Movies.StarWars}",
            Movies.Intersteller => $"My favorite movie is {Movies.Intersteller}",
            Movies.Prometheus => $"My favorite movie is {Movies.Prometheus}",
            _ => $"Mine is {Movies.Alien}"

        };
        return message;

    }






}
