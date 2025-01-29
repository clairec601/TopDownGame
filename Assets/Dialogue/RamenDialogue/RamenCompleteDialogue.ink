EXTERNAL finishQuest(questid)
EXTERNAL changeSprite(character)

-> main

=== main ===
~ changeSprite("ramen")
Wow!
This hot spring is just what I needed :O 
I think I'm gonna soak in here for a while...
~ finishQuest("Ramen")
Thank you!
-> END

== function finishQuest(questid) ==
~ return

== function changeSprite(character) ==
~ return