namespace FourKindTests
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
        public void FourKindTest()
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
                int fou = 0;
                if (y.n1 >= 4 || y.n2 >= 4 || y.n3 >= 4 || y.n4 >= 4 || y.n5 >= 4 || y.n6 >= 4)
                {
                    fou = y.d1 + y.d2 + y.d3 + y.d4 + y.d5;
                }
                if (fou != y.ScoreFourKind()) passing = false;
            }

            if (passing) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are scoring your four of a kind. Remember that you can score a four of a kind as long as you have at least 4 of the same number, and also that when you score a four of a kind it takes the total of all your dice, not just the matching ones.");
        }
    }
}