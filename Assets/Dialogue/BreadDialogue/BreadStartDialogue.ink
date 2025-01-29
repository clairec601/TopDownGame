EXTERNAL startQuest(questid)
EXTERNAL startBreadGame()

-> main

=== main ===

Hello there!
    + [You seem to have lots of energy!]
        -> Response_1
    

=== Response_1 ===
That's cause I do! All these carbs mean that I'm super energized during the day, so I just bounce around like this to keep my loaf moving!
Speaking of moving, wanna play a game? I promise it'll be fun!
    + [Sure, I'll play!]
        -> Sure
    + [Sorry, I'm a little busy.]
        -> Busy
        
=== Sure ===
~ startQuest("Bread")
Yay! Let's go!
~ startBreadGame()
-> END

=== Busy ===
Aw, in that case, be sure to come back if you ever wanna play!
-> END
 
 == function startQuest(questid) ==
~ return // placeholder result

 == function startBreadGame() ==
~ return // placeholder result
