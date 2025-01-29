EXTERNAL finishQuest(questid)
EXTERNAL collectStar()
EXTERNAL changeSprite(character)

-> main

=== main ===
We're back! How was it?
+ [It was pretty fun!]
    -> Respond
+ [So...tired...]
    -> Respond
       
=== Respond ===
~ finishQuest("Bread")
You did great! And I don't know about you, but that definitely helped me get all the extra energy out of my system!
~ collectStar()
~ changeSprite("bread")
Make sure to come and play again soon! By the way, here's a present! I found it on the way back here! 
-> END

== function finishQuest(questid) ==
~ return 

== function collectStar() ==
~ return

== function changeSprite(character) ==
~ return