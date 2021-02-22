using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class RPSApp
    {
        
        public int YourPoints { get; set; } = 0;
        public int ComputerPoints { get; set; } = 0;

        public void Game(IPlayer opponentSelection, RPS humanselection)
        {
            RPS opponentchoice = opponentSelection.GenerateRPS();
           
                                  

           
                
                RPS playerChoice = opponentchoice;

                Console.WriteLine($"You chose: {humanselection}");
                Console.WriteLine($"Opponent chose: {playerChoice}");

                if (humanselection == playerChoice)
                {
                    Console.WriteLine("Draw!");
                }               
                else if (humanselection == RPS.Paper && playerChoice == RPS.Rock)
                {
                    Console.WriteLine("You win!");
                    YourPoints++;
                }
                else if (humanselection == RPS.Scissors && playerChoice == RPS.Paper)
                {
                    Console.WriteLine("You win!");
                    YourPoints++;
                }
                else if (humanselection == RPS.Rock && playerChoice == RPS.Scissors)
                {
                    Console.WriteLine("You win!");
                    YourPoints++;
                }
                else if (humanselection == RPS.Rock && playerChoice == RPS.Paper)
                {
                    Console.WriteLine("You lose!");
                    ComputerPoints++;
                }
                else if (humanselection == RPS.Paper && playerChoice == RPS.Scissors)
                {
                    Console.WriteLine("You lose!");
                    ComputerPoints++;
                }
                else if (humanselection == RPS.Scissors && playerChoice == RPS.Rock)
                {
                    Console.WriteLine("You lose!");
                    ComputerPoints++;
                }

                

                Console.WriteLine($"Your score: {YourPoints}");
                Console.WriteLine($"Opponent score: {ComputerPoints}");

                
            
        }

        public bool PlayAgain()
        {
            string playAgain;

            bool isInvalid;
            do
            {
                Console.WriteLine("Play again? (y/n):");
                playAgain = Console.ReadLine().ToLower();

                isInvalid = playAgain != "y" && playAgain != "n";
                if (isInvalid)
                {
                    Console.WriteLine("Please enter a 'y' or 'n'!" + "\n");
                }
            } while (isInvalid);

            if (playAgain == "n")
            {
                Console.WriteLine("Thanks for playing!");
            }

            return playAgain == "y";
        }

        public RPS GetPlayerChoice(string name)
        {
            HumanPlayer test = new HumanPlayer(name);           
            return test.GenerateRPS();
        }

        public IPlayer GetOpponent(string opponent)
        {        
                        
            do
            {
                Console.WriteLine("Would you like to play against: The Rock or Unknown?");
                opponent = Console.ReadLine().ToLower();

                switch (opponent)
                {
                    case "the rock":
                        return new RockPlayer();
                    case "unknown":
                        return new RandomPlayer();
                    default:
                        Console.WriteLine("Invalid selection!");
                        break;
                }
            } while (true);

        }
    }
}
