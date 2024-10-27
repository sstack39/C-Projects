


using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ShouldReturnSum_WhenGivenTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5, b = 10;

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Subtract_ShouldReturnDiff_WhenGivenTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 10, b = 5;

            // Act
            var result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void Multiply_ShouldReturnProd_WhenGivenTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5, b = 10;

            // Act
            var result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void Divide_ShouldReturnQuot_WhenGivenTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 8, b = 4;

            // Act
            var result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}