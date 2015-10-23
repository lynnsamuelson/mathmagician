using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests //the default namespace is the name of the project
{
    [TestClass]
    public class NaturalNumbersTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            NaturalNumbers nats = new NaturalNumbers();//constructor by default that is available to any class created
            //Asserts class has all types of methods to verify whether someting is true or false
            //has cheates to peak inside the C# files and help you remember the names of methods
            Assert.IsNotNull(nats); //every test has a set-up and then assert
        }

        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int expected = 1;
            int actual = nats.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        /*
        //for education purposes
        [TestMethod]
        [ExpectedException(typeof(AccessViolationException))]
        public void NooneCanAccessPrivateDatamember()
        {
            NaturalNumbers nats = new NaturalNumbers();
            //Whoops Won't even compile ;)
            //nats.first;

        }
        */
        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 1;
            int expected = 2;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumberInput3()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 3;
            int expected = 4;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//testm tab tab to get this (test stab method)
        public void ShouldPrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers(); //set-up instance of this class
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = nats.GetSequence();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]//testm tab tab to get this (test stab method)
        public void ShouldPrintAVariableSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers(); //set-up instance of this class
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = nats.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]//test to show they produce the same output if length equals 10
        public void ShouldProvideSameSequences() 
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 10;
            int[] sequencewithlength = nats.GetSequence(input);
            int[] sequencenolength = nats.GetSequence();
            CollectionAssert.AreEqual(sequencenolength, sequencewithlength);

        }

        [TestMethod]
        public void PrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int length = 7;
            string expected = "1 2 3 4 5 6 7";
            string actual = nats.ToString(nats.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
