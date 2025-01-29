EXTERNAL startQuest(questid)
EXTERNAL finishQuest(questid)
EXTERNAL changeSprite(character)

-> main

=== main ===
<i> sigh. </i>
    + [What's up?]
        -> Ask
        
=== Ask ===
Well, I love flying! It's so fun to float around and feel the wind between my feet.
But, a couple days ago, I accidentally fell and scraped my feathers :(
Luckily, I recovered quickly!
So I'm trying to back into it again, but I keep getting scared. 
    +  [Well, why are you scared?]
        -> RightOne
    +  [Well, it's ok! You don't have to do anything you don't want to.]
        -> WrongOne
        
=== WrongOne ===
That's true... maybe I'll just forget about it for now.
<i> sigh. </i>
(Maybe that was the wrong thing to say...)
-> END

=== RightOne ===
It's just that I remember the pain I felt, and it hurt a lot :(
And then, I freeze up thinking about it.
    + [Yeah, flying is pretty dangerous. You could hurt yourself again.]
        -> WrongTwo
    + [Think about how much you love flying. Maybe it's worth the risk.]
        -> RightTwo

=== WrongTwo ===
Exactly! I don't want to risk getting myself into an even worse accident. 
Maybe it's for the better that I give it up for today. 
<i> sigh. </i>
(Maybe that was the wrong thing to say...)
-> END

=== RightTwo ===
I do love it! I think if I gave up, it would make me super sad. 
But still...
What if I do fall again, even if I'm more careful this time? 
    + [You won't! Trust me.]
        -> WrongThree
    + [You probably will.]
        -> RightThree
        
=== WrongThree ===
    Thank you, but I know you're saying that to make me feel better.
    I just don't think I can get over my fears right now...
    <i> sigh. </i>
    (Maybe that was the wrong thing to say...)
-> END 
    
=== RightThree ===
    What if I do fall again, even if I'm more careful this time?  //repeat maybe?
        + [But the important thing is you get back up and keep trying!]
            -> Encourage

=== Encourage ===
~ startQuest("Banana")
I see...you're right. 
Okay, I'm gonna try! I'll really try!
...
~ changeSprite("banana")
This isn't that bad!
Now that I'm flying again, somehow I'm less scared.
Even if I fall, I think I'll be okay.
~ finishQuest("Banana")
Thanks for listening to me! 
-> END 
    

== function startQuest(questid) ==
~ return

== function finishQuest(questid) ==
~ return

== function changeSprite(character) ==
~ return




    
    
    





    
    
