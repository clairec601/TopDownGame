EXTERNAL startQuest(questid)

-> main

=== main ====
<i>sigh.</i> Where did it go? 
+ [Are you looking for something?]
    -> Ask

=== Ask ===
Well, I woke up from my nap. And I realized that my sock was missing!
I have no idea where it could've gone... Now my paw's cold :(
+ [I hate when my feet are cold too. I'll help you find your sock.]
    -> Help
+ [I hope you find it soon!]
    -> END

=== Help ===
~ startQuest("Bear")
Wow, thank you! I took my nap by those bushes over there, if that helps.
-> END

== function startQuest(questid) ==
~ return 