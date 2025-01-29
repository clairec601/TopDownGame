EXTERNAL startQuest(questid)
EXTERNAL startManateeGame()

-> main

=== main ===
Let's dance!
    + [Okay! Let's go!]
        -> Go
    + [?]
        -> Question
        

=== Question ===
Let's dance!
The music is calling hehe!
    + [Okay, why not!]
        -> Go
    + [??]
        -> QuestionAgain

=== Go ===
~ startQuest("Manatee")
Yay!
~ startManateeGame()
    -> END

=== QuestionAgain ===
Come back later if you wanna join!
    -> END


== function startQuest(questid) ==
~ return

== function startManateeGame() ==
~ return