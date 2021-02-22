using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class RandomPlayer : IPlayer
    {
        public string Name { get; set; }

        public RandomPlayer()
        {
            Name = "Unknown";
        }

        public RPS GenerateRPS()
        {
            var rpsrandom = new Random();
            RPS randomEnum = (RPS)rpsrandom.Next(0, 3);

            return randomEnum;
        }
    }
}
