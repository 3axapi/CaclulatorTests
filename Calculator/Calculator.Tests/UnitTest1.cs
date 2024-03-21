namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ForTwoIn_ReturnsCorrectSum()
        {
            // arrange
            var car = new Calculator();
        }

        [Fact]
        public void Substract_ForTwoInt_ReturnsCorrect_Product()
        {
            // arrange
            var cal = new Calculator();

            // act
            var result = cal.Substruct(20, 30);

            // assert
            Assert.Equal(-10, result);
        }

        [Fact]
        public void Multiply_ForTwoInt_ReturnsCorrect_Product()
        {
            // arrange
            var cal = new Calculator();

            // act
            var result = cal.Multiply(20, 30);

            // assert
            Assert.Equal(600, result);
        }
    }
}