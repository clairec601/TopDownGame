# Stuffed Slumber

One very normal night, you fall asleep in your bed, as you normally do. Then, you seemingly wake up, but not in the same exact bed you fell asleep in; in this game, you enter a grassy dreamland, where your stuffed animals have suddenly come to life! Interact with them and your surroundings, play games, and help resolve some of their concerns before you wake up again! 

INSTRUCTIONS:
Talk to and help out each stuffed animal before waking back up!
* Trigger dialogue: 'space'
* Continue dialogue: 'return'
* Movement: arrow keys ('up', 'down', 'right', 'left')
     * Bread Game: jump using 'up', move using 'right' and 'left'
     * Manatee Game: arrow keys (up', 'down', 'right', 'left') corresponding to arrows on screen
     * Big Dinosaur Game: pluck grass using 'mouse click'
Be sure to talk to characters <b> again </b> after completing a quest step to register the quest as completed! 
    * ex: after you complete a game that required a scene change, talk to the character back in the main game scene
 
## Application Link
Link to built version: https://drive.google.com/file/d/1wGxSRxVrYc1tnTNeW1-Z5gVDkVAGpM4K/view?usp=sharing

## Screenshots/GIFs
Entire World:

<img width="392" alt="Screenshot 2025-01-29 at 10 08 46 PM" src="https://github.com/user-attachments/assets/194feb05-3059-4067-a3d2-e6db509e58a4" />


Sample Character/Scene Art:

![Sunflower](https://github.com/user-attachments/assets/c1b7a77a-816c-479d-9cda-d724ffe7af72)
![Lily Pad](https://github.com/user-attachments/assets/d6c292a4-af42-4db6-9291-84edd9686c38)
![MainCharGIF](https://github.com/user-attachments/assets/a6573265-c38d-4414-a067-c9635e634204)
![MainCharIdleGIF](https://github.com/user-attachments/assets/929e0b4d-0edc-4412-a68d-2200d5613411)
![Ramen GIF](https://github.com/user-attachments/assets/2226fee2-e330-4f4c-a36f-e91197bdeb68)
![OtterGIF](https://github.com/user-attachments/assets/15ea8b42-0527-4928-a2b6-450caaeead74)
![BreadGIF](https://github.com/user-attachments/assets/47022d27-4f26-4983-9bf7-5ff10846e474)

Pig Quest Playthrough:
[Screen Recording 2025-01-29 at 8.05.55 PM.mov.zip](https://github.com/user-attachments/files/18596062/Screen.Recording.2025-01-29.at.8.05.55.PM.mov.zip)


## Setup
Made with Unity Editor Version 2022.3.16f1

## Learning Journey

* I remember, for the Tokyo Olympics in 2020, Google Doodle had created an interactive game, where you would play as a cat, participating in games, and helping out citizens of the island. I absolutely loved playing it through (twice), and I was inspired by its retro pixel-art style and fun interaction-based gameplay to try and create something similar, with some changes. For example, the character you play as is me, and all of the characters that you are able to talk to are actually stuffed animals that I own! I pride myself on owning a family of very unique ones that live on my bed, and thought it would be interesting to recreate them and bring them to life. When I was younger, I used to love playing with them and pretending they were alive, so this game is also a way of fulfilling that dream of mine.
* This game provides a way to replenish your energy and give you a short and sweet escape from reality. Overall, it is a low-stakes, relaxing game that can be played in any cozy environment!
* New Technologies:
    * Unity: I knew that I wanted to use Unity as my platform, as I had learned a little bit in high school (this is my third ever project), and wanted to become more familiar with it. In fact, one of my favorite games was created using Unity! The second code sample I provide is an example of one of the projects I had worked on when I was still learning the most basic fundamentals, and I’m proud to see that I’ve gotten much more used to Unity since then, and I’ve even found that some issues I encountered during my first project, I ended up finding the solutions for in this one.     
    * Ink: I downloaded an extension that could integrate Ink, a narrative scripting platform, with Unity, which was super helpful for writing dialogue and syncing dialogue with C# functions. 
    * Pixel Art: This was my first time trying out pixel art; I used a free app on my iPad to both design my sprites and scene items, and animate them as well. 
* Challenges:
   *  I faced many, many challenges while making this game, and felt many, many emotions while doing so. 
      * Preserving variables and data between scene changes
         * ex: if you collect coconut from tree, then proceed to start another character quest that requires a scene change, the game knows you still have the coconut in your possession
      * Preserving the state of the quests and character-specific animations between scene changes
         * quests do not revert back to 'CAN_START' state after scene change 
      * Creating my own sprites + animating them
      * Transitioning between animations at appropriate times
      * Debugging C# and system errors 
      * etc.

## Authors
Claire Chang


## Acknowledgments
* https://www.youtube.com/watch?v=vY0Sk93YUhA -> inspiration for dialogue system
* https://www.youtube.com/watch?v=UyTJLDGcT64 -> inspiraiton for quest system
* Many posts on Unity Discussions/Stack Overflow/other Internet sources
* My stuffed animals!
* My family and friends for moral support (and for buying me the stuffed animals)
