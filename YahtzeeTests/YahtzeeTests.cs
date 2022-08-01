namespace YahtzeeTests
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
        public void YahtzeeTest()
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

                int yat = 0;

                if (y.d1 == y.d2 && y.d1 == y.d3 && y.d1 == y.d4 && y.d1 == y.d5) yat = 50;

                if (yat != y.ScoreYahtzee()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your yahtzees.");
        }
    }
}