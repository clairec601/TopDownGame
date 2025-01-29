EXTERNAL finishQuest(questid)

-> main

=== main ===
Thanks for helping me out! The itchiness is finally gone...
+ [Try to keep the grass-rolling to a minimum next time.]
    -> Respond
+ [I, too, love to frolick in fields of grass.]
    -> Respond
       
=== Respond ===
~ finishQuest("Big Dinosaur")
Hehe.
I'll see you around!
-> END

== function finishQuest(questid) ==
~ return 
