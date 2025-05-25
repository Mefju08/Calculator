using Calculator.Services;
using FluentAssertions;

namespace Calculator.UnitTests
{
    public class SumServiceTests
    {
        [Theory]
        [InlineData(1,3,4)]
        public void SumService_WithTwoNumbers_ShouldReturnSum(int numA, int numB, int expectedResult)
        {
            var sumService = new SumService();
            int result = sumService.Sum(numA, numB);

            result.Should().Be(expectedResult);
        }
    }
}
