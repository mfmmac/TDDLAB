using System;
using System.Collections.Generic;
using System.Text;

namespace ROSHAMBO
{
    public class Roshambo
    {
        public string Play(string playerOne, string playerTwo)
        {
            var result = "";
            if ((playerOne == "Rock" && playerTwo == "Scissors") || playerTwo == "Rock" && playerOne == "Scissors")
            {
                result = "Rock Wins!";
            }
            else if ((playerOne == "Scissors" && playerTwo == "Paper") || playerTwo == "Paper" && playerOne == "Scissors")
            {
                result = "Scissors Wins!";
            }
            else if ((playerOne == "Paper" && playerTwo == "Rock") || playerTwo == "Rock" && playerOne == "Paper")
            {
                result = "Paper Wins!";
            }
            else
            {
                result = "Tie!";
            }
            return result;
        }
    }
}
