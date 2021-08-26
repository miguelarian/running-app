namespace Metrics
{
    using System;

    public class TimeCalculator : ICalculator
    {
        private float distance;
        private float pace;

        /// <summary>
        /// Creates an instance of <see cref="ICalculator"/> object that calculates running the time required to run a distance in pace.
        /// </summary>
        /// <param name="distance">Distance to run in metres.</param>
        /// <param name="pace">The pace running in minutes per one kilometer.</param>
        public TimeCalculator(float pace, float distance)
        {
            this.pace = pace;
            this.distance = distance;
        }

        public float Calculate()
        {
            float distanceInKm = this.distance / 1000.0f;

            float timeInMinutes = distanceInKm * this.pace;

            float timeInSeconds = timeInMinutes * 60.0f;

            return timeInSeconds;
        }
    }
}
