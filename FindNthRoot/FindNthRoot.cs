using System;

namespace FindNthRootAlgorithm
{
    public class FindNthRoot
    {
        private Random _random = new Random(); // uses random to guess inital value
        /// <summary>
        /// The method applies Newton's method to find Nth root of an input number via given precision 
        /// </summary>
        /// <param name="inputNumber">your input number must be greater than zero</param>
        /// <param name="inputDegree">your input degree has to be greater than zero and Odd!</param>
        /// <param name="inputPrecision">better keep this values between zero and one</param>
        /// <returns>this method returns your desired root</returns>
        public double GetRoot(double inputNumber, int inputDegree, double inputPrecision)
        {
            if ((inputNumber < 0 && inputDegree % 2 == 0) ||
                 inputDegree <= 0 || inputPrecision >= 1  || 
                 inputPrecision < 0) 
            throw new ArgumentOutOfRangeException("Sorry, your input values are not valid!");

            var result = 0.0d;
            var previousResult = _random.Next(10); // generates a random number between 0 and 9
            var deltaDifferenceOfRoots = Double.MaxValue; // gonna help to get the difference of two roots
           
            // iterate till we get the required precision
            while(deltaDifferenceOfRoots > inputPrecision)
            {
                result = ((inputDegree - 1.0) * previousResult + inputNumber / Math.Pow(previousResult, inputDegree - 1)) / (double)inputDegree;
                deltaDifferenceOfRoots = Math.Abs(result - previousResult);
                previousResult = (int)result;
            }

            return result;
        }
    }
}
