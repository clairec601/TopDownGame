EXTERNAL changeSprite(character)
EXTERNAL finishQuest(questid)

-> main

=== main ===
...
~ changeSprite("turtle")
Hi there!
Sorry to make you go through all that trouble! I guess I overslept my alarm...again.
    + [No kidding.]
        -> Comment
    + [You sure are a heavy sleeper...]
        -> Comment
        
=== Comment ===
~ finishQuest("Turtle")
I'll get better, I swear! 
Anyway, guess it's time to start my day now. 
-> END
    
    
== function changeSprite(character) ==
~ return 

== function finishQuest(questid) ==
~ return 