using System;
using NUnit.Framework;

namespace RandomNumberTest
{
    [TestFixture]
    public class Random
    {
        [Test]
        public void GetRandNumber()
        {
            //arrange
            var generateNumber = new GenerateNumber();
            var underTest = new MoreRandomRandomNumber(generateNumber);

            //act
            var actual = underTest.MakeMoreRandom();

            //assert
            Assert.IsNotNull(actual);
        }

        [Test]
        public void GetPredictedRandNumber()
        {
            // arrange
            const int fakeRandomNumber = 3;
            const double predictedResult = 0.28224001611973443;
            var mockGenerateNumber = new MockGenerateNumber(fakeRandomNumber);
            Assert.AreEqual(fakeRandomNumber, mockGenerateNumber.GetNumber());
            var underTest = new MoreRandomRandomNumber(mockGenerateNumber);

            //act
            var actual = underTest.MakeMoreRandom();

            //assert
            Assert.AreEqual(predictedResult, actual);
        }
    }
}
