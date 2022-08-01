namespace FullHouseTests
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
        public void FullHouseTest()
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

                bool pf = false;
                bool tf = false;

                if (y.n1 == 2 || y.n2 == 2 || y.n3 == 2 || y.n4 == 2 || y.n5 == 2 || y.n6 == 2) pf = true;
                if (y.n1 == 3 || y.n2 == 3 || y.n3 == 3 || y.n4 == 3 || y.n5 == 3 || y.n6 == 3) tf = true;

                int fh = 0;
                if (pf && tf) fh = 25;
                if (fh != y.ScoreFullHouse()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your full house section.");
        }
    }
}