namespace LgStraightTests
{
    public class Tests
    {
        Yahtzee y;
        [SetUp]
        public void Setup()
        {
            y = new Yahtzee();
        }

        [Test]
        public void LgStraightTest1()
        {
            y.d1 = 5;
            y.d2 = 1;
            y.d3 = 3;
            y.d4 = 4;
            y.d5 = 2;

            y.NumberOfDice();

            if (y.ScoreLgStraight() == 40) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void LgStraightTest2()
        {
            y.d1 = 5;
            y.d2 = 6;
            y.d3 = 3;
            y.d4 = 2;
            y.d5 = 4;

            y.NumberOfDice();

            if (y.ScoreLgStraight() == 40) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }


        [Test]
        public void LgStraightTest3()
        {
            y.d1 = 5;
            y.d2 = 1;
            y.d3 = 6;
            y.d4 = 2;
            y.d5 = 4;

            y.NumberOfDice();

            if (y.ScoreLgStraight() == 0) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void LgStraightTest4()
        {
            y.d1 = 5;
            y.d2 = 6;
            y.d3 = 3;
            y.d4 = 2;
            y.d5 = 1;

            y.NumberOfDice();

            if (y.ScoreLgStraight() == 0) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }
    }
}