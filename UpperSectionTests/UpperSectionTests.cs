namespace UpperSectionTests
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
        public void AcesTest()
        {
            bool passing = true;
            for(int i = 0; i < 1000; i++)
            {
                y.d1 = r.Next(1, 7);
                y.d2 = r.Next(1, 7);
                y.d3 = r.Next(1, 7);
                y.d4 = r.Next(1, 7);
                y.d5 = r.Next(1, 7);

                y.NumberOfDice();

                if (y.n1 != y.ScoreAces()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your aces (1s).");
        }

        [Test]
        public void TwosTest()
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

                if ((y.n2 * 2) != y.ScoreTwos()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your twos.");
        }

        [Test]
        public void ThreesTest()
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

                if ((y.n3 * 3) != y.ScoreThrees()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your threes.");
        }

        [Test]
        public void FoursTest()
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

                if ((y.n4 * 4) != y.ScoreFours()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your fours.");
        }

        [Test]
        public void FivesTest()
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

                if ((y.n5 * 5) != y.ScoreFives()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your fives.");
        }

        [Test]
        public void SixesTest()
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

                if ((y.n6 * 6) != y.ScoreSixes()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your sixes.");
        }

    }
}