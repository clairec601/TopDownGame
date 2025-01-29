EXTERNAL startQuest(questid)

-> main

=== main ===
<i> brrrr </i>
    + [Are you cold? But the weather is so nice!]
        -> Ask
    + [I'm a little chilly right now too.]
        -> Ask
        
        
=== Ask ===
My soup just needs to warm up a little...
Ramen's best when it's piping hot! Right now, it's still a bit cold :(
Stirring a lot helps distribute the heat, but...
Hm, what should I do?
    + [I'll let you know if I think of a solution.]
        -> Think
    
    + [I'm not sure, but I hope you find the perfect heat source soon!]
        -> END

=== Think ===
~ startQuest("Ramen")
Okay! I'll keep thinking too.
Hm...
-> END


== function startQuest(questid) ==
~ return
        
        

