3D Horror Game Scene
Project Overview
This project aims to create a 3D horror game scene that includes a haunted environment, a player character, and some challenging interactions. The key features of the project include:
- A spooky environment built using an Asset Pack designed for horror games.
- At least three spiders from the "Free Fantasy Spider" asset pack placed throughout the room.
- A player character (zombie-vampire or "Ghoul") that can be controlled using the keyboard, allowing movement and jumping.
- A script that adds 10 points to the player's score when they jump over a spider.
Project Requirements
To meet the project requirements, I have implemented the following components:
1. Ghoul Character Movement
The Ghoul_move script allows the player character (Ghoul) to move using the keyboard. The character can move forward, backward, left, and right, and jump using the spacebar.
2. Spider Movement
Two scripts, MoveSpider and MoveSpiderB, control the movement of the spiders. These scripts make the spiders follow specific target objects, creating a creepy and interactive experience for the player.
3. Ghoul Jumping
The Ghoul_move script also enables the Ghoul to jump when the spacebar is pressed, making navigation through the environment more dynamic.
4. Spider-Jumping Interaction
The BedChairCollision script detects collisions between the Ghoul character and certain objects (e.g., a bed), and when a collision occurs, it adds a force to nearby chairs to create the effect of jumping. This interaction is used to award the player 10 points when they jump over a spider.
5. Scoring System
The Score script manages the player's score, adding 10 points when a collision with a spider is detected. The current score is displayed on the screen using a UI text element.

How to Use
Set up your Unity project and import the necessary assets, including the horror environment asset pack, the Ghoul character, and the spider models.
Attach the provided scripts to the appropriate GameObjects in your Unity scene.
Customize and configure the assets and GameObjects as needed to fit your project's design.
Playtest the scene and control the Ghoul character using the keyboard, navigating around and jumping over the spiders.
Observe the scoring system as the player accumulates points when they successfully jump over a spider. 
