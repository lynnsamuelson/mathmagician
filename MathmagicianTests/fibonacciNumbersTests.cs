using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class fibonacciNumbersTests
    {
        [TestMethod]
        public void FibonacciNumbersEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            Assert.IsNotNull(fibonacci);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            int expected = 0;
            int actual = fibonacci.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintNextNumber()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            int input = 0;
            int expected = 1;
            int actual = fibonacci.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//testm tab tab to get this (test stab method)
        public void FibonacciShouldPrintAVariableSequenceOfNumbers()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers(); //set-up instance of this class
            int input = 8;
            int[] expected = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            int[] actual = fibonacci.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
