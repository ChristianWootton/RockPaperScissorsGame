using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors{
    //In accordance with Robert Martins advice in "Clean Code" (chapter 3, Page 37), 
    //Switch statements should be hidden away, and never repeated.  
    class PlayerInput{
        public string movePerformed;
        int moveChosen = Convert.ToInt32(Console.ReadLine());
        public void PlayerMove(){
            switch (moveChosen){
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
