using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClearMeasure.Core;

namespace ClearMeasure.Core.Tests
{
    [TestClass]
    public class DivisorRequestTests
    {
        
        [TestMethod]
        public void PositiveValueTest()
        {
            int value = 3;
            string message = "yowsa";

            // POsitive test - provide valid values (value > 0, message is populated)
            DivisorRequest dr = new DivisorRequest(value, message);
            
            // object should be constructed with the same values as provided by the constructor 
            Assert.AreEqual(dr.Value, value);
            
            //UnitTestAssertException()
        }

        [TestMethod]
        public void PositiveMessageTest()
        {
            int value = 3;
            string message = "yowsa";

            // POsitive test - provide valid values (value > 0, message is populated)
            DivisorRequest dr = new DivisorRequest(value, message);

            // object should be constructed with the same values as provided by the constructor 
            Assert.AreEqual(dr.Message, message);

            //UnitTestAssertException()
        }

        [TestMethod]
        [ExpectedException( typeof(InvalidDataException))  ]
        public void NegativeValueTest()
        {

            int value = 0;
            string message = "yowsa";
            // this should throw an exception for invalid value field
            DivisorRequest dr = new DivisorRequest(value, message);
            Assert.Fail("no exception thrown");

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void NegativeMessageTest()
        {

            int value = 0;
            string message = "";
            // this should throw an exception for empty message 
            DivisorRequest dr = new DivisorRequest(value, message);
            Assert.Fail("no exception thrown");

        }

    }
}
