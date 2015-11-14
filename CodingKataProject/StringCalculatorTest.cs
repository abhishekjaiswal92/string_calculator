using System;
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
            stringCalculator = new StringCalculator(); 
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
        public int Add_WhenInputHasTwoNumbers_WillReturnSumOfTwoNumbers(string testInput)
        {
            return stringCalculator.Add(testInput);
        }

        [TestCase("10,11,1", Result = 22)]
        [TestCase("100,100,1111", Result = 1311)]
        public int Add_WhenInputHas3Numbers_WillReturnSumOf3Numbers(string testInput)
        {
            return stringCalculator.Add(testInput);
        }
        [TestCase("100,100,1111,123456,12345678,123,1234,12345,123456,1234567,123,234,55,556,100,1555", Result = 13844793)]
        public int Add_WhenInputHasUnknownAmountOfNumbers_WillReturnSumOfAllNumbers(string testInput)
        {
            return stringCalculator.Add(testInput);
        }
        [TestCase("1\n1,2", Result = 4)]
        [TestCase("1\n2", Result=3)]
        [TestCase("1\n2\n3,4\n5", Result =15)]
        [TestCase("1\n", ExpectedException = typeof(FormatException))] //is this correct case?
        [TestCase("1,\n2", ExpectedException = typeof(FormatException))]
        public int Add_WhenInputHasNewLinesBetweenNumber_WillReturnSum(string testInput)
        {
            return stringCalculator.Add(testInput);
        }
    }
}
