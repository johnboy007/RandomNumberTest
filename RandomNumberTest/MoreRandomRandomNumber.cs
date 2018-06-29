using System;

namespace RandomNumberTest
{
    public class MoreRandomRandomNumber:IMoreRandomRandomNumber
    {
        private readonly IGenerateRandomNumber _generateRandomNumber;
        public MoreRandomRandomNumber(IGenerateRandomNumber generateRandomNumber)
        {
            _generateRandomNumber = generateRandomNumber;
        }

        public double MakeMoreRandom()
        {
            return Math.Sin(_generateRandomNumber.GetNumber()) + Math.Sin(_generateRandomNumber.GetNumber());
        }
    }
}