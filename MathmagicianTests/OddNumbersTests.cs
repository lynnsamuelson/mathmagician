using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class OddNumbersTests
    {
        [TestMethod]
        public void OddNumbersEnsureICanCreateClassInstance()
        {
            OddNumbers odd = new OddNumbers();
            Assert.IsNotNull(odd);
        }

        public void OddShouldPrintFirstNumber()
        {
            OddNumbers odd = new OddNumbers();
            int expected = 2;
            int actual = odd.GetFirst();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OddShouldPrintNextNumber()
        {
            OddNumbers odd = new OddNumbers();
            int input = 2;
            int expected = 4;
            int actual = odd.GetNext(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//testm tab tab to get this (test stab method)
        public void OddShouldPrintAVariableSequenceOfNumbers()
        {
            OddNumbers odd = new OddNumbers(); //set-up instance of this class
            int input = 8;
            int[] expected = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] actual = odd.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OddPrintSequenceOfNumbers()
        {
            OddNumbers odd = new OddNumbers();
            int length = 7;
            string expected = "1 3 5 7 9 11 13";
            string actual = odd.ToString(odd.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }


    }
}
