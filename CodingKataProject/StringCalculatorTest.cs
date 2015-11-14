using NUnit.Framework;

namespace CodingKataProject
{
    [TestFixture]
    public class StringCalculatorTest
    {
        private StringCalculator stringCalculator;
        [SetUp]
        public void TestSetup()
        {
            stringCalculator = new StringCalculator(); //is this composition
        }
        
        [Test]
        public void Add_WhenInputIsEmptyString_WillReturn0()
        {
            int sum= stringCalculator.Add("");
            Assert.AreEqual(0,sum);
        }

        [Test]
        [TestCase("1",Result = 1)]
        [TestCase("10", Result = 10)]
        [TestCase("100", Result = 100)]
        
        public int Add_WhenInputHas1Number_WillReturnThatNumber(string testInput)
        {
            return stringCalculator.Add(testInput);
        }
        
        [TestCase("10,11", Result = 21)]
        [TestCase("100,100", Result = 200)]
        public int Add_WhenInputHasTwoNumbers_WillReturnThatNumber(string testInput)
        {
            return stringCalculator.Add(testInput);
        }
    }
}
