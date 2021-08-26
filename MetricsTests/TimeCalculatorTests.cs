namespace MetricsTests
{
    using Metrics;

    using System;

    using Xunit;

    public class TimeCalculatorTests
    {
        [Fact]
        public void Calculate_AllParamsZero_ReturnsZero()
        {
            float distance  = 0.0f;
            float time      = 0.0f;

            ICalculator calculator = new TimeCalculator(distance, time);

            float result = calculator.Calculate();
            float expected = 0.0f;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_45min10km_Returns4_30()
        {
            float distance  = 10000.0f;  // 10km
            float pace      = 4.5f;     // 4:30

            ICalculator calculator = new TimeCalculator(distance, pace);

            float result    = calculator.Calculate();
            float expected  = 2699.9998f; // 45min => should be rounded to 2700s

            Assert.Equal(expected, result);
        }
    }
}
