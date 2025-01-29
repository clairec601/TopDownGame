EXTERNAL startQuest(questid)

-> main

=== main ====
<i> ACHOO! sniffle.<\i>  
+ [Uh...you've got a little something under your nose.]
    -> Continue

=== Continue ===
I know... <i>ACHOO!<\i> 
I think they're allergies. I don't know what they're caused by, but I can't stop sniffling. <i> ACHOO!<\i>  
It's just so annoying... I can't go ten seconds without sneezing, it's driving me crazy! <i> ACHOO!<\i>  
+ [Oh, I totally get what you mean! I'm allergic to tons of things.]
    -> Agree
+ [I'm so sorry! I hope you find a way to stop them.]
    -> Leave

=== Agree ===
Right! Isn't it so annoying?
+ [Finding the source of them will definitely help.]
    -> Suggest
    
=== Suggest ===
You're right. I guess I should start from moving out of this flower patch, huh.
Hm, where should I go now?
+ [I'll help!]
    -> Help

=== Leave ===
<i> ACHOO!<\i>  
-> END

=== Help ===
~ startQuest("Hamster")
Thanks! I have a few places in mind, so let's go.
...
[Click on a place for hamster to move to!]
-> END


== function startQuest(questid) ==
~ return 