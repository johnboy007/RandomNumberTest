namespace RandomNumberTest
{
    public class GenerateNumber: IGenerateRandomNumber
    {
        private readonly System.Random _rand;

        public GenerateNumber()
        {
            _rand = new System.Random();
        }
        public int GetNumber()
        {
            return _rand.Next();
        }
    }
}