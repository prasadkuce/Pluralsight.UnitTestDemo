using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pluralsight.UnitTestDemo.Api;

namespace Pluralsight.UnitTestDemo.Tests
{
    [TestClass]
    public class CalculateFixture
    {
        [TestInitialize]
        public void OnTestInitialize()
        {
            _SystemUnderTest = null;
        }

        private Calculator _SystemUnderTest;

        public Calculator SystemUnderTest
        {
            get
            {
                if (_SystemUnderTest == null)
                {
                    _SystemUnderTest = new Calculator();
                }

                return _SystemUnderTest;
            }


        }
        [TestMethod]
        public void Add()
        {
            //arrange
            var val1 = 1;
            var val2 = 2;
            var expected = 3;
            //act
            var result = SystemUnderTest.Add(val1, val2);
            //assert
            Assert.AreEqual<int>(expected,result,"Add Failed");
        }
        [TestMethod]
        public void Subtract()
        {
            //arrange
            var val1 = 2;
            var val2 = 1;
            var expected = 1;
            //act
            var result = SystemUnderTest.Subtract(val1, val2);
            //assert
            Assert.AreEqual<int>(expected, result, "Subtract Failed");
        }
        [TestMethod]
        public void Multiply()
        {
            //arrange
            var val1 = 1;
            var val2 = 2;
            var expected = 2;
            //act
            var result = SystemUnderTest.Multiply(val1, val2);
            //assert
            Assert.AreEqual<int>(expected, result, "Multiplication Failed");
        }
        [TestMethod]
        public void Divide()
        {
            //arrange
            var val1 = 2;
            var val2 = 1;
            var expected = 2;
            //act
            var result = SystemUnderTest.Divide(val1, val2);
            //assert
            Assert.AreEqual<int>(expected, result, "Division Failed");
        }
        [TestMethod]
        [ExpectedException((typeof(InvalidOperationException)))]
        public void DivideByZeroThrowsException()
        {
            //arrange
            var val1 = 2;
            var val2 = 0;
            //act
            var result = SystemUnderTest.Divide(val1, val2);
        }
    }
}
