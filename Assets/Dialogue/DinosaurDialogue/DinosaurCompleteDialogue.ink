EXTERNAL finishQuest(questid)
EXTERNAL changeSprite(character)

-> main

=== main ===
+ [(Pour your spring water into the cloud.)]
    -> Pour
       
=== Pour ===
~ changeSprite("dinosaur")
~ finishQuest("Dinosaur")
My cactus! It grew back!
Now I don't have to worry about the dry weather.
    + [Go enjoy the sunshine!]
        -> Reply

=== Reply ===
Hehe, I will!
-> END

== function finishQuest(questid) ==
~ return // placeholder result

== function changeSprite(character) ==
~ return // placeholder result