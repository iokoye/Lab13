using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class RockPlayer : IPlayer
    {        
        public string Name { get; set; }

        public RockPlayer()
        {
            Name = "The Rock";
        }

        public RPS GenerateRPS()
        {
            return RPS.Rock;
        }
    }
}
