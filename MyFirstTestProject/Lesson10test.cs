using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;


// Lesson 17 - Unit Testing & Exercise 18

namespace MyFirstTestProject
{
    [TestClass]
    public class Lesson10test
    {
        [TestMethod]
        public void FirstName_LastName_ZipCode_Verify()
        {
            // arragne
            string firstName = "George";
            string lastName = "Washington";
            int zipCode = 64119;
            Lesson10 lesson10 = new Lesson10(firstName, lastName, zipCode);

            // act - Nothing for this one

            // assert
            Assert.AreEqual(firstName, lesson10.FirstName);
            Assert.AreEqual(lastName, lesson10.LastName);
            Assert.AreEqual(zipCode, lesson10.Zipcode);


        }

    }
    /*
     Problem 1 -  Write a test method inside the Lesson10Test.cs file. Ensure you
     have the [Test method] above this method. This method will be called
     iDVerify. We will be utilizing the arrange and assert portions of the AAA pattern.
     Create a variable of int called id. Provide a value for this variable.
     Create an object of Lesson 10 using the default constructor. Using the object
     created, assign the id variable to the ID property. Using an Assert, we are 
     going to check to see if the ID property was assigned properly, or if its 
     still using the default value of 1000. Pick through the Assert methods to 
     determine which would fit. There are more than 1 possible methods to test this,
     including the one used in the lecture. Run the test several times to ensure
     you get both a passing test and a failure. Ensure you provide a passing version
     in your checked code. You only need to provide 1 assert + method.
     */
    [TestClass]
    public class Lesson10
    {
        [TestMethod]
        public void IDVerify()
        {
            // arragne
            int id = 234;
            Lesson10 lesson10 = new Lesson10(id);

            // act - Nothing for this one

            // assert
            Assert.AreEqual(id, lesson10.ID);


        }

    }


    


}