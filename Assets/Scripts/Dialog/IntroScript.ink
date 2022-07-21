VAR seenIntro = false

Hi there! //look into adding in the person's name to use here
+ {seenIntro} -> Hello
* {not seenIntro} -> Intro

=== Hello ===
+ Hello! -> Choices
* Goodbye. -> Goodbye

=== Choices ===
What would you like to know?

 + What is this place? -> Intro
 + What are the controls? -> Controls
 + Who are you? -> Guard
 * Nothing. -> Goodbye
 
//Need this(Intro) to happen automatically once. Then need a bool to be set if intro has been encountered before, to stop it happening again automatically. If bool is true, Choices will appear first instead.
=== Intro ===
Welcome to Somer's PD hub museum. Here you will find a whole host of rooms dedicated to the various works of Somer.

 + Who? -> Somer
 + A PD hub museum? -> Museum
 + Test -> Choices
 
 === Controls ===
 You can press the WASD keys to go forward, left, backwards and right respectively.
 Moving your mouse will control the camera.
 Holding down shift whie moving will allow you to run, or pressing ctrl will make you dash for a short time.
 You can usually press E to interact with objects, although some objects may have multiple interaction buttons. When you get close to these objects, they will tell you what each button does.
 
  + Thank you.
  
  No problem. Is there anything else? -> Choices
  
 === Guard ===
 Me? I am the museum guard, although really I am more like a concierge. I am here to welcome you to this world and to provide you with all the information you should need to get around. -> GuardOps
 
=== GuardOps ===
 + Do you have a name?
    A name? You are a very polite person! My name is Gregory. -> GuardOps
 + Where can I find you?
    You can find me walking around the museum. -> GuardOps
 + I know enough about you now. -> Choices
 
=== Somer ===
Somer is the creator of this world. It is a world designed to host and showcase various things that Somer has done. -> Choices

=== Museum ===
Yes, a museum. -> Choices

=== Goodbye ===
- Goodbye, we hope you enjoy your visit.
    -> END
