
namespace MyFirstApplication;

// Exercise 16 - Collections

internal class Exercise16
/*
  Problem 1 - Write a method that has no parameters and no return type. Create
a list<T> of your Horse objects. When creating your list, utilize all the 
constructors you created with your horse class, Using a foreach loop, print our the 
results of the collection using a console writeline statement.
 
 */
{
   public void Exercise16List()
    {
        List<string> myHorseList = new List<string>();
        myHorseList.Add("HorseColor");
        myHorseList.Add("TailLength");
        myHorseList.Add("HorseType");
        myHorseList.Add("Hoovecolor");

        foreach(string horse in myHorseList)
        {
            Console.WriteLine(horse);
        }


    }

/*
 Problem 2 - Write a method that has no parameters and no return type. Using only the data you used
when building your favorite movies from exercise 15, create a Dictionary collection
that takes an int key and string value. When adding Dictionary elements, pick an int
value as the key and use the favorite movies data as the string.Using a foreach
loop, print out the results of your collection using a Console Writeline statement.
 */
   
    public void DictionaryCollection()
    {
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "Star Wars series");
        myDictionary.Add(2, "Intersteller");
        myDictionary.Add(3, "Prometheus");
        myDictionary.Add(4, "Alien");

        string value;
        if(myDictionary.TryGetValue(1, out value))
        {
            Console.WriteLine($"For key 1, the value is {value}");
        }

        foreach(KeyValuePair<int, string> pair in myDictionary)
        {
            Console.WriteLine($"Key : { pair.Key}, Value: {pair.Value}");
        }

    }




}
