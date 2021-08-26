namespace Metrics
{
    using System;

    public class DistanceCalculator : ICalculator
    {
        private float pace;
        private float time;

        /// <summary>
        /// Creates an instance of <see cref="ICalculator"/> object that calculates running distance in metres.
        /// </summary>
        /// <param name="pace">Pace running in minutes per kilometer.</param>
        /// <param name="time">Time running in seconds.</param>
        public DistanceCalculator(float pace, float time)
        {
            if (pace == 0 || time == 0)
            {
                throw new ArgumentException("Parameters must be greater than zero");
            }

            this.pace = pace;
            this.time = time;
        }

        public float Calculate()
        {
            float minutesRunning    = this.time / 60.0f;

            float kilometersRun     = minutesRunning / this.pace;

            float metresRun         = kilometersRun * 1000.0f;

            return metresRun;
        }
    }
}
