EXTERNAL startQuest(questid)

-> main

=== main ===
<i>slurp.</i> Already...?
+ [What's wrong?]
    -> Ask 
       
=== Ask ===
I've run out of coconut milk again... Could I bother you to get some more for me?
    + [Sure!]
        -> Sure
    + [I've got other things to do]
        -> Busy
        
=== Sure ===
~ startQuest("Pig")
Thank you!
-> END


=== Busy ===
Okay...
-> END

== function startQuest(questid) ==
~ return // placeholder result