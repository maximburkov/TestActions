using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            Calculator c = new Calculator();

            // Act
            var res = c.Add(1, 2);

            // Assert
            Assert.AreEqual(5, res);
        }
    }
}
