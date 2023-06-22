using XUnit_Acceptanstestning;
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
            var actual = calculator.Add(2, 2);
            var expected = 4;

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
            var actual = calculator.Subtract(25, 8);
            var expected = 17;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 10, 10)]
        [InlineData(100, 30, 70)]
        [InlineData(20, 5, 15)]
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
            var actual = calculator.Divide(50, 10);
            var expected = 5;

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
            var actual = calculator.Multiply(9, 9);
            var expected = 81;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2.5, 4, 10)]
        [InlineData(7.125, 7.125, 50.765625)]
        [InlineData(-10, 10, -100)]
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
        public void UppdateLog_Test()
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.UppdateLog(10, 10, 20, "+");
            var actualNum1 = calculator.log[0].Num1;
            var actualNum2 = calculator.log[0].Num2;
            var actualResult = calculator.log[0].Output;
            var actualOpperator = calculator.log[0].Operate;

            var expectedNum1 = "10";
            var expectedNum2 = "10";
            var expectedResult = "20";
            var expectedOpperator = "+";

            // Assert
            Assert.Equal(expectedNum1, actualNum1);
            Assert.Equal(expectedNum2, actualNum2);
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedOpperator, actualOpperator);
        }

        [Theory]
        [InlineData(15, 15, 30, "+", "15", "15", "30", "+")]
        [InlineData(7, 7, 49, "*", "7", "7", "49", "*")]
        [InlineData(110, 50, 60, "-", "110", "50", "60", "-")]
        [InlineData(81, 9, 9, "/", "81", "9", "9", "/")]
        [InlineData(1000, 0, 0, "*", "1000", "0", "0", "*")]
        public void UppdateLog_Theory_Test(double num1, double num2, double result, string opperator, string expectedNum1, string expectedNum2, string expectedResult, string expectedOpperator)
        {
            // Arrange
            Math calculator = new Math();

            // Act
            var actual = calculator.UppdateLog(num1, num2, result, opperator);
            var actualNum1 = calculator.log[0].Num1;
            var actualNum2 = calculator.log[0].Num2;
            var actualResult = calculator.log[0].Output;
            var actualOpperator = calculator.log[0].Operate;


            // Assert
            Assert.Equal(expectedNum1, actualNum1);
            Assert.Equal(expectedNum2, actualNum2);
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedOpperator, actualOpperator);
        }

        [Fact]
        public void ShowMathLog_Test()
        {
            // Arrange
            Math calculator = new Math();
            calculator.UppdateLog(33, 33, 66, "+");

            // Act
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            calculator.ShowMathLog();
            var actualOutput = consoleOutput.ToString();
            var expectedOutput = "33 + 33 = 66\n";

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [InlineData(20, 20, 400, "*", "20 * 20 = 400\n")]
        [InlineData(1000, 10000, 0.1, "/", "1000 / 10000 = 0,1\n")]
        [InlineData(7.25, 2.5, 4.75, "-", "7,25 - 2,5 = 4,75\n")]
        [InlineData(1, 2, 3, "+", "1 + 2 = 3\n")]
        [InlineData(0, 0, 0, "*", "0 * 0 = 0\n")]
        public void ShowMathLog_Theory_Test(double num1, double num2, double result, string opperator, string expectedOutput)
        {
            Math calculator = new Math();
            calculator.UppdateLog(num1, num2, result, opperator);

            // Act
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            calculator.ShowMathLog();
            var actualOutput = consoleOutput.ToString();

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
