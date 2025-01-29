EXTERNAL finishQuest(questid)
EXTERNAL changeSprite(character)

-> main

=== main ===
What do I do?
+ [Here's your coconut.]
    -> Give
       
=== Give ===
~ finishQuest("Pig")
~ changeSprite("pig")
Thank you! Thank you! The doctor told me to cut down on my intake, but it's just so delicious, you know? <i> slurp. <\i> 
-> END

== function finishQuest(questid) ==
~ return // placeholder result

== function changeSprite(character) ==
~ return // placeholder result