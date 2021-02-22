using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSApp again = new RPSApp();
            Console.Write("Welcome to Rock Paper Scissors! \n");
            Console.Write("Enter your name: ");
            string humanName = Console.ReadLine();

            

            RPSApp playerselected = new RPSApp();
            do
            {                
                playerselected.Game(playerselected.GetOpponent("The Rock"), playerselected.GetPlayerChoice(humanName));
               
            } while (again.PlayAgain());
            
            
        }



    }
}
