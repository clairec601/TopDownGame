EXTERNAL startQuest(questid)

-> main

=== main ===
...
+ [Hello!]
    -> Hello
    
    
=== Hello ===
~ startQuest("Turtle")
...
+ [(Maybe I should come back later.)]
    -> END
    
== function startQuest(questid) ==
~ return