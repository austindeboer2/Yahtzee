namespace ChanceTests
{
    public class Tests
    {
        Yahtzee y;
        Random r;
        [SetUp]
        public void Setup()
        {
            y = new Yahtzee();
            r = new Random();
        }

        [Test]
        public void ChanceTest()
        {
            bool passing = true;
            for (int i = 0; i < 1000; i++)
            {
                y.d1 = r.Next(1, 7);
                y.d2 = r.Next(1, 7);
                y.d3 = r.Next(1, 7);
                y.d4 = r.Next(1, 7);
                y.d5 = r.Next(1, 7);

                y.NumberOfDice();
                int tot = y.d1 + y.d2 + y.d3 + y.d4 + y.d5;
                
                if (tot != y.ScoreChance()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your chance section.");
        }
    }
}