using NUnit.Framework;
using Tdd;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTests.Tdd
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CheckSum()
        {
            //AAA

            //Arrange
            var calc = new Calculator();

            //Act

            var result = calc.Sum(5, 2);

            //Assert
            Assert.AreEqual(7, result);
        }
    }
}