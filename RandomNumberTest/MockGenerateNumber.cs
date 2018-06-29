namespace RandomNumberTest
{
    public class MockGenerateNumber : IGenerateRandomNumber
    {
        private readonly int _fakeRandomNumber;

        public MockGenerateNumber(int fakeRandomNumber)
        {
            _fakeRandomNumber = fakeRandomNumber;
        }
        public int GetNumber()
        {
            return _fakeRandomNumber;
        }
    }
}