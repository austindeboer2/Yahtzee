namespace ScoringTests
{

    public class Tests
    {
        /*
         * xxxxo
         * xxxox
         * xxoxx
         * xoxxx
         * oxxxx
         */

        Yahtzee y;
        [SetUp]
        public void Setup()
        {
            y = new Yahtzee();
        }

        [Test]
        public void SmStraightTest1()
        {
            y.d1 = 6;
            y.d2 = 1;
            y.d3 = 3;
            y.d4 = 4;
            y.d5 = 2;

            y.NumberOfDice();

            if (y.ScoreSmStraight() == 30) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void SmStraightTest2()
        {
            y.d1 = 5;
            y.d2 = 4;
            y.d3 = 3;
            y.d4 = 2;
            y.d5 = 4;

            y.NumberOfDice();

            if (y.ScoreSmStraight() == 30) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void SmStraightTest3()
        {
            y.d1 = 3;
            y.d2 = 1;
            y.d3 = 2;
            y.d4 = 2;
            y.d5 = 4;

            y.NumberOfDice();

            if (y.ScoreSmStraight() == 30) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void SmStraightTest4()
        {
            y.d1 = 1;
            y.d2 = 1;
            y.d3 = 3;
            y.d4 = 2;
            y.d5 = 4;

            y.NumberOfDice();

            if (y.ScoreSmStraight() == 30) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void SmStraightTest5()
        {
            y.d1 = 1;
            y.d2 = 4;
            y.d3 = 3;
            y.d4 = 5;
            y.d5 = 6;

            y.NumberOfDice();

            if (y.ScoreSmStraight() == 30) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void SmStraightTest6()
        {
            y.d1 = 5;
            y.d2 = 1;
            y.d3 = 6;
            y.d4 = 2;
            y.d5 = 4;

            y.NumberOfDice();

            if (y.ScoreSmStraight() == 0) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }

        [Test]
        public void SmStraightTest7()
        {
            y.d1 = 5;
            y.d2 = 6;
            y.d3 = 3;
            y.d4 = 2;
            y.d5 = 1;

            y.NumberOfDice();

            if (y.ScoreSmStraight() == 0) Assert.Pass();
            else Assert.Fail("These were your dice at the time of failure - " + "d1: " + y.d1 + " d2: " + y.d2 + " d3: " + y.d3 + " d4: " + y.d4 + " d5: " + y.d5);
        }
    }
}