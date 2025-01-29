EXTERNAL changeSprite(character)

-> main

=== main ===
Wanna try my socks on?
    + [Sure!]
        -> Wear
    + [You should keep them.]
        -> Deny
        
=== Wear ===
~ changeSprite("bear")
~ changeSprite("mainChar")
Aren't they nice?
...
~ changeSprite("bear")
Okay, you can give them back now. 
They're my only pair :(
~ changeSprite("mainChar")
~ changeSprite("bear")
Hehe thanks!
-> END

=== Deny ===
If you say so! Come back if you change your mind!
-> END
    
    
== function changeSprite(character) ==
~ return 