using System;

namespace Metrics
{
    public class PaceCalculator : ICalculator
    {
        private readonly float ONE_KM_IN_METRES = 1000f;
        private readonly float ONE_MINUTE_IN_SECONDS = 60f;

        private float distance;
        private float time;

        /// <summary>
        /// Creates an instance of <see cref="ICalculator"/> object that calculates running pace in minutes per kilometer.
        /// </summary>
        /// <param name="distance">Distance to run in metres.</param>
        /// <param name="time">Time running in seconds.</param>
        public PaceCalculator(float distance, float time)
        {
            if(distance == 0 || time == 0)
            {
                throw new ArgumentException("Parameters must be greater than zero");
            }

            this.distance = distance;
            this.time = time;
        }

        public float Calculate()
        {
            float distanceInKm = this.distance / ONE_KM_IN_METRES;
            float timeInMinutes = this.time / ONE_MINUTE_IN_SECONDS;

            return timeInMinutes / distanceInKm;
        }
    }
}
