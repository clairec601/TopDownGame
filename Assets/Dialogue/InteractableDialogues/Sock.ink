EXTERNAL collectSock()

-> main

=== main ===
Whose sock is this?
+ [What a wonderful sock!]
    -> Admire
+ [I'll take it with me.]
    -> Take

=== Admire ===
(You admire the singular sock.)
-> END


=== Take ===
~ collectSock()
(You obtained one sock!)
(You can never have too many.)
-> END

== function collectSock() ==
~ return // placeholder result
