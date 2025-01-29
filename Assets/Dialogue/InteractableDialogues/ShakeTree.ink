EXTERNAL collectCoconut()

-> main

=== main ===
Just a tree.
+ [What a wonderful tree!]
    -> Choice_1
+ [Shake.]
    -> Choice_2

=== Choice_1 ===
You admire the tree.
-> END


=== Choice_2 ===
Nothing happened.
+ [Shake harder.]
    -> Shake

=== Shake ===
~ collectCoconut()
You obtained one coconut! 
-> END

== function collectCoconut() ==
~ return // placeholder result
