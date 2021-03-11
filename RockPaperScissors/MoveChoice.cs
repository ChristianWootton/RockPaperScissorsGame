using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors{
    //Attempting to stop repeat code by moving the switch statement to a separate class. 
    class MoveChoice{
        public string movePerformed; 
        public int moveChosen;
        public MoveChoice(int _move){
            switch (_move){
                case 1: 
                    movePerformed = "Rock";
                    break;
                case 2: 
                    movePerformed = "Paper";
                    break;
                case 3: 
                    movePerformed = "Scissors";
                    break;
            }
        }
    }
}
