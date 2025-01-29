EXTERNAL finishQuest(questid)
EXTERNAL changeSprite(character)

-> main

=== main ====
~ finishQuest("Otter")
+ [I think I may have found something!]
    -> Give

=== Give ===
Wow! So shiny!
~ changeSprite("otter")
This is perfect! I'm gonna go play with this now. Bye!
    -> END

== function finishQuest(questid) ==
~ return 

== function changeSprite(character) ==
~ return 