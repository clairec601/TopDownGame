EXTERNAL startQuest(questid)
EXTERNAL startBigDinosaurGame()

-> main

=== main ====
<i> scratch. scratch.<\i>  
ARGHH
+ [Are you okay?]
    -> Ask

=== Ask ===
My back...so itchy... Would you mind?
+ [(Scratch.)]
    -> Scratch
+ [Uh... I've got other things to do.]
    -> Deny

=== Scratch ===
Phew, thanks! I love rolling around in the grass in my little patch, but I think some blades got stuck to my fur. But I can't see them since, well. They're on my back. 
Hey, could you take a look for me? Pluck out all the grass you see. Help a dino out. 
+ [Sure. I've got great eyes!]
    -> Help

=== Deny ===
:( 
-> END

=== Help ===
~ startQuest("Big Dinosaur")
Hooray!
~ startBigDinosaurGame()
-> END


== function startQuest(questid) ==
~ return 

== function startBigDinosaurGame ==
~ return 