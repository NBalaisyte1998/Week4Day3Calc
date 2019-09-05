using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;



namespace CalculatorTest
{


    [TestClass]
    public class UnitTest1
    {
        Calculator.Calculator clc;
        [TestInitialize]
        public void Initialize()
        {
            clc = new Calculator.Calculator();

        }
        [TestMethod]
        public void TestMethod1()
        {
            //setup 
            double valueInput1 = 10;
            double valueInput2 = 2;
            double expectedOutput = 5;

            //running the test
            double result = clc.Divide(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            //Calculator.Calculator clc = new Calculator.Calculator();
            int valueInput1 = 6;
            int valueInput2 = 2;
            int expectedOutput = 12;

            double result = clc.Multiply(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Calculator.Calculator clc = new Calculator.Calculator();
            int valueInput1 = 8;
            int valueInput2 = 5;
            int expectedOutput = 13;

            double result = clc.Add(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
           // Calculator.Calculator clc = new Calculator.Calculator();
            int valueInput1 = 15;
            int valueInput2 = 3;
            int expectedOutput = 12;

            double result = clc.Minus(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);
        }
        public void CleanUpMethod()
        {
            clc = null;
        }

    }
}
