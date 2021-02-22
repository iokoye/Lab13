using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public HumanPlayer()
        {

        }

        public RPS GenerateRPS()
        {
            string response;

            while (true)
            {
                Console.WriteLine($"Welcome, {Name}! Make your choice of Rock, Paper, or Scissors: ");
                response = Console.ReadLine();

                switch (response, StringComparison.OrdinalIgnoreCase)
                {
                    case ("Rock", StringComparison.OrdinalIgnoreCase):
                        return RPS.Rock;
                    case ("Paper", StringComparison.OrdinalIgnoreCase):
                        return RPS.Paper;
                    case ("Scissors", StringComparison.OrdinalIgnoreCase):
                        return RPS.Scissors;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}
