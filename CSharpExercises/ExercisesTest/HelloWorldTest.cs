using Exercises.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void GreetWithNameOK()
        {
            Assert.AreEqual("Hello Oscar!", HelloWorld.Greet("Oscar"));
        }

        [TestMethod]
        public void GreetWithoutNameOK()
        {
            Assert.AreEqual("Hello World!", HelloWorld.Greet());
        }
    }
}