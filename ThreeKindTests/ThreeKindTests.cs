namespace ThreeKindTests
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
        public void ThreeKindTest()
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
                int thr = 0;
                if (y.n1 >= 3 || y.n2 >= 3 || y.n3 >= 3 || y.n4 >= 3 || y.n5 >= 3 || y.n6 >= 3)
                {
                    thr = y.d1 + y.d2 + y.d3 + y.d4 + y.d5;
                }
                if (thr != y.ScoreThreeKind()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your three of a kind. Remember that you can score a three of a kind as long as you have at least 3 of the same number, and also that when you score a three of a kind it takes the total of all your dice, not just the matching ones.");
        }
    }
}