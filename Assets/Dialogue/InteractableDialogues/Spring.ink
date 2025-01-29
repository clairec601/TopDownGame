EXTERNAL collectWater()

-> main

=== main ===
What a wonderful spring!
    + [My pajamas are getting wet.]
        -> Leave
    + [(Take some water for the road.)]
        -> Take
        

=== Leave ===
(You back away. Pajamas don't come cheap these days.)
-> END

=== Take ===
~ collectWater()
Good to stay hydrated!
-> END

== function collectWater() ==
~ return