using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;

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
}