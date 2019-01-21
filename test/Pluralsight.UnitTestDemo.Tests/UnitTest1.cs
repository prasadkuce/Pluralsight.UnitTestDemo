using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pluralsight.UnitTestDemo.Api;

namespace Pluralsight.UnitTestDemo.Tests
{
    [TestClass]
    public class CalculateFixtre
    {
        [TestMethod]
        public void Add()
        {
            //arrange
            var val1 = 1;
            var val2 = 2;
            var expected = 3;
            //act
            var sut = new Calculator();
            var result = sut.Add(val1, val2);
            //assert
            Assert.AreEqual<int>(expected,result,"Add Failed");
        }
    }
}
