using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClearMeasure.Core.Tests
{
    [TestClass]
    public class FantasticIteratorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void NegativeIteratorRequestTest()
        {

            int startValue = -2;
            int endValue = -2;
            string result = "";

            // this should throw an exception for empty message 
            FantasicIterator fi = new FantasicIterator();
            fi.AddRequest(new DivisorRequest(5, "yowsa"));
            result = fi.Iterate(startValue, endValue);
            Assert.Fail("no exception thrown");

        }


        [TestMethod]
        public void PositiveIteratorRequestTest()
        {

            int startValue = 1;
            int endValue = 5;
            int requestNumber = 5;
            string requestMessage = "yowsa";

            string result = "";

            // this should successfully return a string with the word 'yowza' in it 
            FantasicIterator fi = new FantasicIterator();
            fi.AddRequest(new DivisorRequest(requestNumber, requestMessage));
            result = fi.Iterate(startValue, endValue);
            Assert.IsTrue(result.IndexOf(requestMessage) > 0);

        }

    }
}
