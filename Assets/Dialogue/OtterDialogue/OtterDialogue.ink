EXTERNAL startQuest(questid)

-> main

=== main ====
~ startQuest("Otter")
Hm...
+ [Hello!]
    -> Hello

=== Hello ===
Hello! Huh, you're not from around here, are you? 
Anyway, now that we're friends, I need you to help me out heh.
I'm waiting for my new shiny rock to come in the mail, but it's been taking so long. 
I need something else to play with till then, or else I'll start to get super bored! 
+ [Hm, I don't have any ideas right now.]
Yeah, me either. But if you find something that I might like, let me know! Especially something shiny!
    -> END

== function startQuest(questid) ==
~ return 