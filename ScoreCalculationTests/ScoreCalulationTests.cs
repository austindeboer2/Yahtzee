namespace ScoreCalculationTests
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
        public void ScoreCalcTest1()
        {
            bool passed = true;
            y.InstantiateVariables();
            for(int i = 1; i < 14; i++)
            {
                if (y.CalculateScoreFromSelection(i) == false) passed = false;
            }

            if (passed) Assert.Pass();
            else Assert.Fail("There seems to be a problem with the logic you are using to determine if a player is cabable to score their dice.");
        }

        [Test]
        public void ScoreCalcTest2()
        {
            bool passed = true;
            y.InstantiateVariables();
            
            y.aces = 0;
            y.twos = 0;
            y.threes = 0;
            y.fours = 0;
            y.fives = 0;
            y.sixes = 0;
            y.threeOfKind = 0;
            y.fourOfKind = 0;
            y.fullHouse = 0;
            y.smStraight = 0;
            y.lgStraight = 0;
            y.yahtzee = 0;
            y.chance = 0;
            
            
            for (int i = 1; i < 14; i++)
            {
                if (y.CalculateScoreFromSelection(i) == true) passed = false;
            }

            if (passed) Assert.Pass();
            else Assert.Fail("There seems to be a problem with the logic you are using to determine if a player is cabable to score their dice.");
        }

        [Test]
        public void ScoreCalcTest3()
        {
            bool passed = true;
            y.InstantiateVariables();
            y.d1 = 5;
            y.d2 = 5;
            y.d3 = 5;
            y.d4 = 5;
            y.d5 = 5;

            if (y.CalculateScoreFromSelection(14) == true) passed = false;

            y.yahtzee = 50;
            if(y.CalculateScoreFromSelection(14) == false) passed = false;
            

            if (passed) Assert.Pass();
            else Assert.Fail("There seems to be a problem with the logic you are using to determine if a player is cabable to score their bonus yahtzee.");
        }
    }
}