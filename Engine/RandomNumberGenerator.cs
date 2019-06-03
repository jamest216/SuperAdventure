using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minVal, int MaxVal)
        {
            byte[] randomNumber = new byte[1];
            _generator.GetBytes(randomNumber);

            double asciiValOfRandChar = Convert.ToDouble(randomNumber[0]);

            //we are using math.max and subtracting 0.00000000001
            //to ensure "multiplier" will always be betweem 0.0 and .99999999999
            //otherwise, its possible for it to be "1", which causes problems in our rounding

            double multiplier = Math.Max(0, (asciiValOfRandChar / 255d) - 0.00000000001d);

            //we need to add one to the range, to allow for the rounding done with math.floor

            int range = MaxVal - minVal + 1;
            double randValInRange = Math.Floor(multiplier * range);

            return (int)(minVal + randValInRange);
        }
    }
}
