# CMP6206_Starter-repo

## TODO: Add the following details and update regularly

1. Name of your project - The ink & Bone Cafe

2. Description/overview - What AI features will the project have/showcase and in what way will they be realised.  For example, for FSM what type of agents will be created using FSM such as enemies, companion, allies, etc.  

    Current features:
    1. FSM

3. Target game engine - Note: you should add an appropriate .gitignore file for the game engine you are using so you don't end up uploading extraneous files that increase the size of the repo.  There are .gitignore files for Unity and Unreal, and other game engines, available from https://github.com/github/gitignore.  For C++ using Visual Studio use the Visual Studio .gitignore but note that it needs some modification as .lib files necessary for building a C++ project are ignored by default.

    Target Game Engine:
    Unity

4. Research - background to the project such as inspiration and what you need to find out to achieve the AI features.  If real behaviour is to be implemented then examples such as flocking or using Artificial Life (ALife) approaches such as cellular automata should be used to support your project and provide a means of comparison of how successful your implementation is.

5. Methodology/planning - what approach are you going to take to develop the project implementation successfully.  For example, use of Trello or KANBAN.  Ideally, you have an overall plan for project development showing the major milestones to be achieved, e.g. setup up scene, implement AI methods, testing (for Quality Assurance), etc.

6. Progress documentation - regular commits/updates to the project need to be documented with a brief overview and reflection on what has been achieved.  For example, what feature(s) have been added?  Were they achieved in the time allowed?  What problems were there or remain?  What has been learnt and what would you do differently if you had to repeat the project?

7. References to sources used.  This must include graphics resources used such as models and textures, and code resources (websites, book, AI).
-----------------------------------------------------------------------------------------------
# The Ink & Bone Café

In a forgotten town, hidden from the world, lies the Ink & Bone Café, a place where stories are more than just words on a page. Frequented by those with tales to tell and secrets to keep, the café harbors a dark mystery that goes beyond its worn leather chairs and the intoxicating scent of coffee.

Detective Steele, a man driven by the ghosts of unsolved cases, finds solace in the café's quiet corners. But as he sips his coffee and trades words with the enigmatic barista, he begins to notice strange things, stories that feel all too familiar, names that shouldn't be known. Each visit pulls him deeper into a web of shadows, where the line between fiction and reality blurs.
When a crucial clue leads him back to the café, Steele must face the possibility that the answers he seeks may come at a terrible cost. But in a place where stories come to life, some truths are better left undiscovered.

In a world where every book has a story, and every story has an ending, Steele is about to discover that some endings can't be escaped.

Step inside, if you dare, but remember: not all who enter the Ink & Bone Café leave unchanged.

 - Project Overview

This Unity project explores artificial intelligence techniques through the behaviour of customers visiting The Ink & Bone Café.

The development process will be documented through a series of records, covering implemented AI techniques, testing, unexpected behaviour and lessons learned.

 - Development Records

*Record 001: The First Customer*
----------------------------------------
The café has welcomed its first customer. Basic movement and behaviour are being developed using a Finite State Machine (FSM), allowing the customer to transition between Idle and Moving states.

There have been some complications with the seating arrangements.

Reginald has been informed.

AI Implementation

Finite State Machine (FSM)

Idle and Moving states

Distance checking using Vector3.Distance()

State transitions based on the customer's distance from their destination

Problems Encountered

The customer initially moved towards the chair before reaching the till. This highlighted a problem with how the destination and state changes were being handled.



Next Steps

Continue developing the customer's behaviour.


*Record 002: *
----------------------------------------