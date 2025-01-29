EXTERNAL placeRamen()

-> main

=== main ===
Woah!
    + [What a wonderful hot spring!]
        -> Admire
    + [Why is there a hot spring here?]
        -> Burn
        
=== Admire ===
(You admire the hot spring.)
    + [(I know who this would be perfect for.)]
        -> Idea

=== Burn ===
Ouch!
(Some of the water splashes you :( )
(You back away slowly. You cannot trust it anymore.)
-> END

=== Idea ===
(You admire the hot spring.)
    + [(Place Ramen in hot spring.)]
        -> Place
        
=== Place ===
~ placeRamen()
There!
-> END
        
== function placeRamen() ==
~ return