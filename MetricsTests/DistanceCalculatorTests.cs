namespace MetricsTests
{
    using Metrics;

    using System;

    using Xunit;

    public class DistanceCalculatorTests
    {
        [Fact]
        public void Calculate_AllParamsZero_ReturnsZero()
        {
            float pace = 0.0f;
            float time = 0.0f;

            Action act = () => new PaceCalculator(pace, time);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Parameters must be greater than zero", exception.Message);
        }

        [Fact]
        public void Calculate_60min6minKm_Returns10Km()
        {
            // 60min a 6min/1km => 10km

            float pace = 6.0f;      // 6:00
            float time = 3600.0f;   // 60 minutes

            ICalculator calculator = new DistanceCalculator(pace, time);

            float result        = calculator.Calculate();
            float expected      = 10000.0f; // 10km

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_3h_4min15sKm_ReturnsMarathon()
        {
            float pace = 4.25f;     // 4:15
            float time = 10800.0f;  // 3 hours

            ICalculator calculator = new DistanceCalculator(pace, time);

            float result    = calculator.Calculate();
            float expected  = 42352.94f; // 4:15 => missing some decimals to match 42.195km exactly

            Assert.Equal(expected, result);
        }
    }
}
