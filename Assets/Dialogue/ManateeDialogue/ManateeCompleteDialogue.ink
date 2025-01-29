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
Even if there's no music, moving to your own beat, making up a melody in your head...
What's not to love?
-> END


== function finishQuest(questid) ==
~ return

