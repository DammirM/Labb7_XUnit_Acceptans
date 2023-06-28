using Math = Labb7_XUnit_Acceptans.Math;

namespace XUnit_Acceptanstestning_Tests
{
    public class MathTest

    {
        [Fact]
        public void Add_Test()
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Add(5,5);
            var expected = 10;

            // Assert
            Assert.Equal(expected, actual);
        }

        // test
        [Theory]
        [InlineData(10, 10, 20)]
        [InlineData(20, 20, 40)]
        [InlineData(100, 100, 200)]
        [InlineData(300, 300, 600)]
        [InlineData(-50, -50, -100)]
        public void Add_Theory_Test(double num1, double num2, double expected)
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Add(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_Test()
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Subtract(10, 5);
            var expected = 5;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 10, 10)]
        [InlineData(100, 30, 70)]
        [InlineData(0, -5, 5)]
        [InlineData(10, 0, 10)]
        public void Subtract_Theory_Test(double num1, double num2, double expected)
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_Test()
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Divide(10, 5);
            var expected = 2;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 10, 1)]
        [InlineData(25, -5, -5)]
        [InlineData(6, 4, 1.5)]
        [InlineData(-80, 2, -40)]
        [InlineData(-100, -10, 10)]
        public void Divide_Theory_Test(double num1, double num2, double expected)
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_Test()
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Multiply(10, 5);
            var expected = 50;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2.5, 4, 10)]
        [InlineData(33, 33, 1089)]
        [InlineData(55, 55, 3025)]
        [InlineData(-10, -10, 100)]
        public void Multiply_Theory_Test(double num1, double num2, double expected)
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void SeeLog_Test()
        {
            // Arrange
            Math calculator = new Math();
            calculator.UppdateLog(10, 5, 5, "-");

            // Act
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            calculator.SeeLog();
            var actual = consoleOutput.ToString();
            var expected = "10 - 5 = 5\n";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 20, 400, "*", "20 * 20 = 400\n")]
        [InlineData(1000, 10000, 0.1, "/", "1000 / 10000 = 0,1\n")]
        [InlineData(7.25, 2.5, 4.75, "-", "7,25 - 2,5 = 4,75\n")]
        [InlineData(1, 2, 3, "+", "1 + 2 = 3\n")]
        [InlineData(0, 0, 0, "*", "0 * 0 = 0\n")]
        public void SeeLog_Theory_Test(double num1, double num2, double result, string Operate, string expected)
        {
            Math calculator = new Math();
            calculator.UppdateLog(num1, num2, result, Operate);

            // Act
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            calculator.SeeLog();
            var actual = consoleOutput.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
