EXTERNAL finishQuest(questid)
EXTERNAL changeSprite(character)

-> main

=== main ===
<i> sniff </i>
+ [I think I know what the problem might be. Here.]
    -> Replace
       
=== Replace ===
~ finishQuest("Hamster")
~ changeSprite("hamster")
Oh, I see! So I was allergic to the daisies in the patch...
That's a little sad, they're so pretty to look at! But I love sunflowers just as much!
Thanks for helping me out! <i>sniff</i>
-> END

== function finishQuest(questid) ==
~ return // placeholder result

== function changeSprite(character) ==
~ return // placeholder result