# ShipSpace---GameWithLives


I've tooked the basic of the code we received in class and made some changes.
first, I add a health System which made the player have 3 lives.
to do so, I have created an array which contains 3 spaces and in Unity i created
an image which got that script x3 times and made the health down every time
the player contradict the enemy.

In part b of this mission Ive decided to add lives every time the player reach 10 points (score%10).
maximum lives player can get is 3. so if he has 3 lives and got 10 more points, nothing changes.

to do so, i changed a little bit in the main code:

https://github.com/Oimit/ShipSpace---GameWithLives/blob/main/Assets/Scripts/3-collisions/ScoreAdder.cs - 
here i added the code that adding lives to the player, on the function "OnTriggerEnter2D".

https://github.com/Oimit/ShipSpace---GameWithLives/blob/main/Assets/Scripts/4-levels/HeartSystem.cs - 
The HealthSystem i made to increase and decrease lives.

itch.io: https://amitay2022.itch.io/gamedev-spaceship
