EXTERNAL startQuest(questid)
EXTERNAL startDinosaurGame()

-> main

=== main ===
When will it rain again...
    + [You don't like the hot weather?]
        -> Ask
    + [I know! I love the smell of rain.]
        -> Ask
        
    
=== Ask ===
It's just been so dry lately...my plant needs to be watered :(
I tried using the water from the lake, but there's nothing like fresh rainwater to really get a cactus growing!

What should I do?
    + [I have an idea.]
        -> Start
        

=== Start ===
~ startQuest("Dinosaur")
Really? Okay, I trust you!
...
(I think I know what to do.)
~ startDinosaurGame()
-> END 


== function startQuest(questid) ==
~ return

== function startDinosaurGame() ==
~ return

