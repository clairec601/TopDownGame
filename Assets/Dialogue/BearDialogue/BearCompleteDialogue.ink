EXTERNAL finishQuest(questid)
EXTERNAL changeSprite(character)

-> main

=== main ===
<i> sigh. </i>
+ [Is this your sock?]
    -> Give
       
=== Give ===
~ finishQuest("Bear")
WOAH IT IS!
Let me put it on!
~ changeSprite("bear")
I was afraid I would never be able to find the left one. Imagine having to wear only one sock for the rest of your life. That would be pretty scary. 
If you ever wanna try them on, let me know! They're super comfy!
-> END

== function finishQuest(questid) ==
~ return // placeholder result

== function changeSprite(character) ==
~ return // placeholder result