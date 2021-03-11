using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors{
    //In accordance with Robert Martins advice in "Clean Code" (chapter 3, Page 37), 
    //Switch statements should be hidden away, and never repeated.  
    public class EnemyInput{
        public string movePerformed;
        public void EnemyMove(){
            int randomMove;
            Random randomNumberMove = new Random();
            randomMove = randomNumberMove.Next(1,4);

            switch (randomMove){
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
