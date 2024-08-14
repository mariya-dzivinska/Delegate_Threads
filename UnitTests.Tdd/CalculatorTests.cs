using Moq;
using NUnit.Framework;
using Tdd;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTests.Tdd
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(10,3, 13)]
        [TestCase(-2, 3, 1)]
        [TestCase(0, 0, 0)]
        public void CheckSum(int a, int b, int expected)
        {
            //AAA

            //Arrange
            var managerMock = new Mock<ValueManager>();
            var calc = new Calculator(managerMock.Object);

            //Act

            var result = calc.Sum(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(10,  20)]
        [TestCase(-2,  8)]
        [TestCase(0,  10)]
        public void CheckSumWithOneValue(int a, int expected)
        {
            //AAA

            //Arrange
            var managerMock = new Mock<ValueManager>();
            var calc = new Calculator(managerMock.Object);

            managerMock.Setup(x => x.GetValue(It.IsAny<int>()))
                .Returns(10);

            //Act

            var result = calc.SumWithOneValue(a);

            //Assert
            Assert.AreEqual(expected, result);

            managerMock.Verify(x => x.GetValue(0), Times.Once);
        }

        [Test]
        public void CheckSumWithOneValueThrowEx()
        {
            //AAA

            //Arrange
            var managerMock = new Mock<ValueManager>();
            var calc = new Calculator(managerMock.Object);

            managerMock.Setup(x => x.GetValue(It.IsAny<int>()))
                .Returns(10);

            //Act //Assert

            Assert.ThrowsException<FileNotFoundException>(() => calc.SumWithOneValue(0));
        }
    }
}