using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
  //This code was provided by the owner of the tutorial. 
    //There is alot of repeat code, the score does not seem to work and 
    //neither does asking if the player would like to play again.
    //My goal is to take this tutorial, and apply Robert C. Martins "Clean Code" to it. 
    class MainGame{
        static void Main(string[] args){
            Console.WriteLine("Please choose a move: 1:Rock, 2:Paper or, 3:Scissors");
            PlayerInput player = new PlayerInput();
            EnemyInput enemy = new EnemyInput();
            enemy.EnemyMove();
            player.PlayerMove();
            Console.WriteLine("The enemy has chose: {0}", enemy.movePerformed);
            Console.WriteLine("You chose: {0}", player.movePerformed);   
            //If Else statment rather long, but doubt it can be shortened due to its nature. 
            //Best case scenario was to define draw/win scenario then anything else is a loss scenario. 
            if(enemy.movePerformed == player.movePerformed){
                Console.WriteLine("Result is a draw");
            }
            else if ((enemy.movePerformed == "Rock" && player.movePerformed == "Paper") || (enemy.movePerformed == "Paper" && player.movePerformed == "Scissors")|| (enemy.movePerformed == "Scissors" && player.movePerformed == "Rock")){
                Console.WriteLine("You have WON!");
            }
            else 
                Console.WriteLine("You have LOST!");

            //CODE PROVIDED
            
            /*string inputPlayer, inputCPU;
            int randomInt;
            
            bool playAgain = true;
 
            while (playAgain){
 
                int scorePlayer = 0;
                int scoreCPU = 0;
 
                while (scorePlayer < 3 && scoreCPU < 3){
                    
 
                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
 
                    Random rnd = new Random();
 
                    randomInt = rnd.Next(1, 4);
 
                    switch (randomInt){
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK"){
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER"){
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS"){
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER"){
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK"){
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS"){
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS"){
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK"){
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER"){
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
 
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);
 
                }
 
                if (scorePlayer == 3){
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3){
                    Console.WriteLine("CPU WON!");
                }
                else{
 
                }
 
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y"){
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n"){
                    playAgain = false;
                }
                else{ 
                
                }
 
            }*/
        }
    }
}
