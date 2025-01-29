EXTERNAL collectSunflower()

-> main

=== main ===
So beautiful!
+ [I'll leave them for somebody else to admire!]
    -> Admire
+ [I'll take one for the road.]
    -> Take

=== Admire ===
(You hope that the next person will love them as much as you do.)
-> END


=== Take ===
~ collectSunflower()
(You obtained one sunflower!)
-> END

== function collectSunflower() ==
~ return // placeholder result
