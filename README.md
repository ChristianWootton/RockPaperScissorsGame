# RockPaperScissorsGame
 Small Tutorial/Project
Small tutorial by https://www.youtube.com/watch?v=WJCNxT2bolg&ab_channel=MeNamesMarty

Update 1: 
Followed basic switch statement of tutorial, created method to distinguish win scenario. 
Result is "Win" regardless. 

Update 2: 
Scrapped provided code, kept methodology. Disected into 3 main components. 
PlayerInput
EnemyInput 
Program

Switch statement is repeated twice. Next goal to implement a "Switch" class? 
Both Input classes can derive their move from that. 

Update 3: 
Put switch statement in separate class with a constructor that takes an int, the switch then uses this int
to derive which move is being made. Both input classes use this to get the move made. 
The MainGame class uses this information to determine the outcome. 
Using the first few chapters of Clean Code as a guide on naming conventions, method/class structures and 
opinions on switch statements, I believe I have managed to successfully clean up the code and make it simple to understand
while maintaining complexity and the producing a product with the overall goal of playing RPS. 