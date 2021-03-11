using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors{
    //In accordance with Robert Martins advice in "Clean Code" (chapter 3, Page 37), 
    //Switch statements should be hidden away, and never repeated.  
    class PlayerInput{       
        public string movePerformed; 
        int moveChosen = Convert.ToInt32(Console.ReadLine()); 
        public void PlayerDecision(){
            MoveChoice choice = new MoveChoice(moveChosen);
            choice.moveChosen = moveChosen;
            movePerformed = choice.movePerformed;
        }
    }
}
