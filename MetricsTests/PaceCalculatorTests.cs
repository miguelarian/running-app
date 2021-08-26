namespace MetricsTests
{
    using Metrics;

    using System;

    using Xunit;

    public class PaceCalculatorTests
    {
        [Fact]
        public void Calculate_AllParamsZero_ReturnsZero()
        {
            float distance  = 0.0f;
            float time      = 0.0f;

            Action act = () => new PaceCalculator(distance, time);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Parameters must be greater than zero", exception.Message);
        }

        [Fact]
        public void Calculate_10kmIn35min_Returns3_30()
        {
            float distance  = 10000.0f;  // 10km
            float time      = 2100.0f;       // 35min

            ICalculator calculator = new PaceCalculator(distance, time);

            float result    = calculator.Calculate();
            float expected  = 3.5f; // 3:30

            Assert.Equal(expected, result);
        }
    }
}
