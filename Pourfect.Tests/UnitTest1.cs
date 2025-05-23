using Xunit;
using Pourfect.Services;

namespace Pourfect.Tests
{
    public class BrewCalculatorTests
    {
        [Fact]
        public void CalculateCoffeeDose_ReturnsCorrectResult()
        {
            var service = new BrewCalculatorService();
            double result = service.CalculateCoffeeDose(320); // 320g water
            Assert.Equal(20, result); // 320 / 16 = 20
        }
    }
}