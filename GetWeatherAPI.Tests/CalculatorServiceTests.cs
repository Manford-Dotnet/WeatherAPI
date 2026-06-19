using GetWeatherAPI.Services;

namespace GetWeatherAPI.Tests
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void Add_Should_Return_Correct_Result()
        {
            // Arrange
            var service = new CalculatorService();

            // Act
            var result = service.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }
    }
}