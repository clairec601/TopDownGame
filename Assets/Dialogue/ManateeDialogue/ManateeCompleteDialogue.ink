EXTERNAL finishQuest(questid)

-> main

=== main ===
Phew, I'm beat!
Have you danced before?
    + [All the time!]
        -> Reply
    + [All the time in my room!]
        -> Reply
        
=== Reply ===
~ finishQuest("Manatee")
Hehe, wasn't it great?
Moving to the beat, swaying to the music...
What's not to love?
-> END


== function finishQuest(questid) ==
~ return

