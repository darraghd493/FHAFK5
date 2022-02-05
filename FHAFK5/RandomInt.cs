using System;

namespace FHAFK5
{
    /// <summary>
    /// This is used for randomizing values used for timing.
    /// </summary>
    public class RandomInt
    {
        private Random random = new Random();

        public int randomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public void refreshRandom()
        {
            random = new Random();
        }
    }
}
