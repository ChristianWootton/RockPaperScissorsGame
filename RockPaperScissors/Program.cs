using System;

namespace RockPaperScissors{
    class Program{
        static void Main(string[] args){
            string inputPlayer, inputEnemy, result;
            int randomInt;

            Console.WriteLine("Choose 1:Rock, 2:Paper or 3:Scissors.");
            inputPlayer = Console.ReadLine();

            Random numberGnerated = new Random();
            randomInt = numberGnerated.Next(1,4);
            //Testing purposes. 
            //randomInt = 2;
            //inputPlayer = "Paper";
            
            
            Console.WriteLine(randomInt);

            switch (randomInt)
            {
                case 1: 
                    inputEnemy = "Rock";
                    endGameScenario();
                    break;
                case 2: 
                    inputEnemy = "Paper";
                    endGameScenario();
                    break;
                case 3: 
                    inputEnemy = "Scissors";
                    endGameScenario();
                    break;
            }
            void endGameScenario(){
                if (inputEnemy == inputPlayer){
                    result = "DRAW!";
                }
                else if ((inputPlayer == "Rock" && randomInt == 2) || (inputPlayer == "Paper" && randomInt == 3) || (inputPlayer == "Scissors" && randomInt == 1)){
                    result = "Enemy Wins";
                }
                else {
                    result = "Player Wins";
                }
                Console.WriteLine(result);
            }
        }        
    }
}
