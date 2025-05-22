namespace Pourfect.Services
{
    public class BrewCalculatorService
    {
        public double CalculateCoffeeDose(double waterAmount, double ratio = 16.0)
        {
            return waterAmount / ratio;
        }
    }
}