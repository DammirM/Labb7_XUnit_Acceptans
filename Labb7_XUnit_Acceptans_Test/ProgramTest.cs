namespace Calculator_Labb_7_TestX
{
    public class ProgramTest
    {
       
        [Fact]
        public void getNum_Test()
        {
            // Arrange
            var input = new StringReader("50");
            Console.SetIn(input);

            // Act
            var actual = Labb7_XUnit_Acceptans.Program.getNum();
            double expected = 50;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("50", 50)]
        [InlineData("200", 200)]
        [InlineData("-350", -350)]
        [InlineData("-33,33", -33.33)]
        [InlineData("12,23", 12.23)]
        public void getNum_Theory(string input, double expected)
        {
            // Arrange
            var consoleInput = new StringReader(input);
            Console.SetIn(consoleInput);

            // Act
            var actual = Labb7_XUnit_Acceptans.Program.getNum();

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}