public class Yahtzee
{
    bool gameComplete;    
    Random random;
    
    //Dice Variables
    public int d1;    
    public int d2;    
    public int d3;    
    public int d4;    
    public int d5;

    //Variables for the amount of each dice value
    public int n1 = 0;
    public int n2 = 0;
    public int n3 = 0;
    public int n4 = 0;
    public int n5 = 0;
    public int n6 = 0;

    //Score Variables
    public int aces;    
    public int twos;    
    public int threes;    
    public int fours;    
    public int fives;    
    public int sixes;    
    public int bonus;    
    public int threeOfKind;    
    public int fourOfKind;    
    public int fullHouse;    
    public int smStraight;    
    public int lgStraight;    
    public int yahtzee;    
    public int chance;    
    public int yahtzeeBonus;
    public int totalScore;    

    /*
     * Resets all the variables to start the game. 
     */
    public void InstantiateVariables()
    {
        gameComplete = false;
        random = new Random();
        d1 = random.Next(1, 7);
        d2 = random.Next(1, 7);
        d3 = random.Next(1, 7);
        d4 = random.Next(1, 7);
        d5 = random.Next(1, 7);
        aces = -1;
        twos = -1;
        threes = -1;
        fours = -1;
        fives = -1;
        sixes = -1;
        bonus = 0;
        threeOfKind = -1;
        fourOfKind = -1;
        fullHouse = -1;
        smStraight = -1;
        lgStraight = -1;
        yahtzee = -1;
        chance = -1;
        yahtzeeBonus = 0;
        totalScore = 0;
    }

    /*
     * Rolls the dice for the player and tells the player what they rolled.
     */
    public void RollDice(String keep)
    {
        if (!keep.Contains("1")) d1 = random.Next(1, 7);
        if (!keep.Contains("2")) d2 = random.Next(1, 7);
        if (!keep.Contains("3")) d3 = random.Next(1, 7);
        if (!keep.Contains("4")) d4 = random.Next(1, 7);
        if (!keep.Contains("5")) d5 = random.Next(1, 7);
        Console.WriteLine("You rolled: " + d1 + ", " + d2 + ", " + d3 + ", " + d4 + ", " + d5);
    }

    /*
     * Constructor: Makes a new game reseting all the variables
     */
    public Yahtzee()
    {
        InstantiateVariables();
    }

    /*
     * Main method that runs the basic game loop for yahtzee
     */
    public static void Main(string[] args)
    {
        Yahtzee y = new Yahtzee();
        while (true)
        {
            y.InstantiateVariables();

            Console.WriteLine("~~~~~~~Yahtzee~~~~~~\n");
            Console.WriteLine("Press Enter to Start");
            Console.ReadLine();
            while (!y.gameComplete)
            {
                y.RollDice("");
                Console.WriteLine("What dice you you like to keep?");
                y.RollDice(Console.ReadLine());
                Console.WriteLine("What dice you you like to keep?");
                y.RollDice(Console.ReadLine());
                y.AddScore();
                Console.Clear();
                y.WriteScore();
            }
            Console.Clear();
            Console.WriteLine("Final Score");
            y.WriteScore();
        }
    }

    /*
     * This uses the CalculateScoreFromSelection to get the players input and score their dice.
     */
    public void AddScore()
    {
        //Writes score
        WriteScore();
        //Figures out how many of each dice there are
        NumberOfDice();

        //Used to determine if dice were scored on the board
        bool scoreFound = false;

        //Loop as long as there is not a valid scoring location
        while (scoreFound == false)
        {
            //Used to see if the user types in a number
            bool numericAnswer = false;
            //Records what the player would like to score
            int scoreSelection = 0;
            
            //Loops while trying to get the player to type in a number.
            while (!numericAnswer)
            {
                //Trys to complete the code to turn a string number into an int number
                try
                {
                    scoreSelection = Int32.Parse(Console.ReadLine());
                    numericAnswer = true;
                }
                //Catch, catches errors from the try code. If the player types in anything that is not a number this code will execute.
                catch
                {
                    Console.WriteLine("Please enter a valid number only.");
                }
            }

            //This runs the students function and sets scoreFound = true if there is a score that was recorded.
            if (CalculateScoreFromSelection(scoreSelection)) 
            {
                scoreFound = true;            
            }
            else
            {
                //Writes this to the player when they did not enter a valid place to score their dice.
                Console.WriteLine("You cannot select that at this time. Please select again.");

            }
        }
        //Once the player has scored their dice this will clear the screen and rewrite the players score.
        Console.Clear();
        WriteScore();

    }

    /*
     * The following is the score selection table for numbers to what the player would like to score. 
     * 1: aces
     * 2: twos
     * 3: threes
     * 4: fours
     * 5: fives
     * 6: sixes
     * 7: threeOfKind
     * 8: fourOfKind
     * 9: fullHouse
     * 10: smStraight
     * 11: lgStraight
     * 12: yahtzee
     * 13: chance
     * 14: bonusYahtzee
     * 
     * For all of these except bonus yahtzee the scores start at -1. This is to determine whether or not the player has placed a score in this catagory or not yet. 
     * To determine if the player is allowed to score any but bonusYahtzee you need to only check to see if that is what the player has selected and that the corresponding score is still set to -1.
     * 
     * For bonus yahztee to be scored you need to verify that this is what the player would like to score, that the player has a yahtzee, and that the score for yahtzee = 50 (verifying that they have already recived a yahtzee)
     * 
     * As far a the return boolean, you need to return true if a score was recorded and false if there was no score recorded. This will be used to make sure the player can still record a score if they type in the wrong number.
     */
    public bool CalculateScoreFromSelection(int scoreSelection)
    {
        
    }

    /*
     * This function takes the scores that have been recorded and writes out a display for the player. 
     */
    public void WriteScore()
    {
        Console.Clear();
        Console.WriteLine("Where would you like to add your score?");
        Console.WriteLine("You rolled: " + d1 + ", " + d2 + ", " + d3 + ", " + d4 + ", " + d5);
        if (aces != -1) Console.WriteLine("1. Aces: " + aces);
        else Console.WriteLine("1. Aces: ");


        if (twos != -1) Console.WriteLine("2. Twos: " + twos);
        else Console.WriteLine("2. Twos: ");


        if (threes != -1) Console.WriteLine("3. Threes: " + threes);
        else Console.WriteLine("3. Threes: ");


        if (fours != -1) Console.WriteLine("4. Fours: " + fours);
        else Console.WriteLine("4. Fours: ");


        if (fives != -1) Console.WriteLine("5. Fives: " + fives);
        else Console.WriteLine("5. Fives: ");


        if (sixes != -1) Console.WriteLine("6. Sixes: " + sixes);
        else Console.WriteLine("6. Sixes: ");

        if ((aces + twos + threes + fours + fives + sixes) >= 63) bonus = 35;
        else bonus = 0;
        Console.WriteLine("Bonus: " + bonus);

        if (threeOfKind != -1) Console.WriteLine("7. 3 of a Kind: " + threeOfKind);
        else Console.WriteLine("7. 3 of a Kind: ");


        if (fourOfKind != -1) Console.WriteLine("8. 4 of a Kind: " + fourOfKind);
        else Console.WriteLine("8. 4 of a Kind: ");


        if (fullHouse != -1) Console.WriteLine("9. Full House: " + fullHouse);
        else Console.WriteLine("9. Full House: ");


        if (smStraight != -1) Console.WriteLine("10. SM Straight: " + smStraight);
        else Console.WriteLine("10. SM Straight: ");


        if (lgStraight != -1) Console.WriteLine("11. LG Straight: " + lgStraight);
        else Console.WriteLine("11. LG Straight: ");


        if (yahtzee != -1) Console.WriteLine("12. Yahtzee: " + yahtzee);
        else Console.WriteLine("12. Yahtzee: ");

        if (chance != -1) Console.WriteLine("13. Chance: " + chance);
        else Console.WriteLine("13. Chance: ");

        if (yahtzeeBonus != -1) Console.WriteLine("14. Yahtzee Bonus: " + yahtzeeBonus);
        else Console.WriteLine("14. Yahtzee Bonus: ");

        totalScore = (aces + twos + threes + fours + fives + sixes + bonus + threeOfKind + fourOfKind + fullHouse + smStraight + lgStraight + yahtzee + chance + yahtzeeBonus);
        if (aces == -1) totalScore++;
        if (twos == -1) totalScore++;
        if (threes == -1) totalScore++;
        if (fours == -1) totalScore++;
        if (fives == -1) totalScore++;
        if (sixes == -1) totalScore++;
        if (threeOfKind == -1) totalScore++;
        if (fourOfKind == -1) totalScore++;
        if (fullHouse == -1) totalScore++;
        if (smStraight == -1) totalScore++;
        if (lgStraight == -1) totalScore++;
        if (yahtzee == -1) totalScore++;
        if (chance == -1) totalScore++;
        if (yahtzeeBonus == -1) totalScore++;
        if (totalScore == (aces + twos + threes + fours + fives + sixes + bonus + threeOfKind + fourOfKind + fullHouse + smStraight + lgStraight + yahtzee + chance + yahtzeeBonus)) gameComplete = true;
        Console.WriteLine("Total: " + totalScore + "\n\n");
    }

    //HINT: If you write methods call SumDice, and CheckYahtzee you will find that you can use them in multiple places to save time. 

    /*
     * This function takes the dice that are currently rolled and puts them into accending order from d1 to d5.
     */
    public void OrderDice()
    {
        int[] order = new int[] { d1, d2, d3, d4, d5 };
        Array.Sort(order);
        Console.WriteLine(order.ToString());

        d1 = order[0];
        d2 = order[1];
        d3 = order[2];
        d4 = order[3];
        d5 = order[4];
    }

    /*
     * Return 1 * the number of 1s on dice faces
     */
    public int ScoreAces()
    {

    }

    /*
     * Return 2 * the number of 2s on dice faces
     */
    public int ScoreTwos()
    {
        
    }

    /*
     * Return 3 * the number of 3s on dice faces
     */
    public int ScoreThrees()
    {
        
    }

    /*
     * Return 4 * the number of 4s on dice faces
     */
    public int ScoreFours()
    {
        
    }

    /*
     * Return 5 * the number of 5s on dice faces
     */
    public int ScoreFives()
    {
        
    }

    /*
     * Return 6 * the number of 6s on dice faces
     */
    public int ScoreSixes()
    {
        
    }

    /*
     * Three of a kind: 3 of one number. EX: 33315
     * If you have three of a kind return the sum of all 5 dice, if not return 0.
     */
    public int ScoreThreeKind()
    {
        
    }

    /*
     * Four of a kind: 4 of one number. EX: 33335
     * If you have four of a kind return the sum of all 5 dice, if not return 0.
     */
    public int ScoreFourKind()
    {
        
    }

    /*
     * Full House: 3 of one number 2 of another. EX: 33355
     * If you have a full house return 25 points, if not return 0.
     */
    public int ScoreFullHouse()
    {
        
    }

    /*
     * If you have a small straight this is worth 30 points, if not score 0;
     * SM Straight: Any 4 numbers in a row.
     * To do this you will want to use the function OrderDice()
     * 
     * Hint:
     * xxxxo
     * xxxox
     * xxoxx
     * xoxxx
     * oxxxx
     */
    public int ScoreSmStraight()
    {
        
    }

    /*
     * If you have a large straight this is worth 40 points, if not score 0;
     * LG Straight: Any 5 numbers in a row.
     * To do this you will want to use the function OrderDice()
     */
    public int ScoreLgStraight()
    {
        
    }

    /*
     * If you have a yahtzee this is worth 50 points, if not score 0;
     */
    public int ScoreYahtzee()
    {
        
    }

    /*
     * Return the sum of all dice
     */
    public int ScoreChance()
    {

    }

    //Returns the score for a yahtzee bonus
    public int ScoreYahtzeeBonus()
    {
        return 100;
    }

    //This function, once run, will set all the variables n1-n6 to the number of respective dice that are currently in play.
    public void NumberOfDice()
    {
        n1 = 0;
        n2 = 0;
        n3 = 0;
        n4 = 0;
        n5 = 0;
        n6 = 0;

        //Check die 1
        if (d1 == 1) n1++;
        if (d1 == 2) n2++;
        if (d1 == 3) n3++;
        if (d1 == 4) n4++;
        if (d1 == 5) n5++;
        if (d1 == 6) n6++;

        //Check die 2
        if (d2 == 1) n1++;
        if (d2 == 2) n2++;
        if (d2 == 3) n3++;
        if (d2 == 4) n4++;
        if (d2 == 5) n5++;
        if (d2 == 6) n6++;

        //Check die 3
        if (d3 == 1) n1++;
        if (d3 == 2) n2++;
        if (d3 == 3) n3++;
        if (d3 == 4) n4++;
        if (d3 == 5) n5++;
        if (d3 == 6) n6++;

        //Check die 4
        if (d4 == 1) n1++;
        if (d4 == 2) n2++;
        if (d4 == 3) n3++;
        if (d4 == 4) n4++;
        if (d4 == 5) n5++;
        if (d4 == 6) n6++;

        //Check die 5
        if (d5 == 1) n1++;
        if (d5 == 2) n2++;
        if (d5 == 3) n3++;
        if (d5 == 4) n4++;
        if (d5 == 5) n5++;
        if (d5 == 6) n6++;
    }
}