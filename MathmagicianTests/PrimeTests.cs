using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class PrimeTests
    {

        [TestMethod]
        public void PrimeNumbersEnsureICanCreateClassInstance()
        {
            Prime prime = new Prime();
            Assert.IsNotNull(prime);
        }

        [TestMethod]
        public void PrimeShouldPrintFirstNumber()
        {
            Prime prime = new Prime();
            int expected = 2;
            int actual = prime.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintNextNumber()
        {
            Prime prime = new Prime();
            int input = 2;
            int expected = 3;
            int actual = prime.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//testm tab tab to get this (test stab method)
        public void PrimeShouldPrintAVariableSequenceOfNumbers()
        {
            Prime prime = new Prime(); //set-up instance of this class
            int input = 8;
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] actual = prime.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PrimeFindIndexOfElement()
        {
            Prime prime = new Prime();
            int input = 73;
            int expected = 19;
            int actual = prime.FindIndex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeIsPrime()
        {
            Prime prime = new Prime();
            int input = 73;
            bool expected = true;
            bool actual = prime.IsPrime(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeIsNotPrime()
        {
            Prime prime = new Prime();
            int input = 70;
            bool expected = true;
            bool actual = prime.IsPrime(input);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PrimeFinIndexOfElementFails()
        {
            Prime prime = new Prime();
            int input = 103;
            prime.FindIndex(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PrimeGetNextNonPrime()
        {
            Prime prime = new Prime();
            int input = 105;
            prime.GetNext(input);
        }
    }
}

