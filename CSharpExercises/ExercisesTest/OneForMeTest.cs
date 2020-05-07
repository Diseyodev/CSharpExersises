using Exercises.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class OneForMeTest
    {
        [TestMethod]
        public void OnForMeWithNameOK()
        {
            Assert.AreEqual("One for Oscar, one for me!", OneForMe.Speak("Oscar"));
        }

        [TestMethod]
        public void GreetWithoutNameOK()
        {
            Assert.AreEqual("One for you, one for me!", OneForMe.Speak());
        }
    }
}