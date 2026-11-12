# CMP6206_Starter-repo

## TODO: Add the following details and update regularly

1. Name of your project - The ink & Bone Cafe

2. Description/overview - What AI features will the project have/showcase and in what way will they be realised.  For example, for FSM what type of agents will be created using FSM such as enemies, companion, allies, etc.  

    Current features:
    1. FSM
    2. Behaviour Trees
    3. GOAP (basic)

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

 - *Development Records*

*Record 001: The First Customer*
----------------------------------------
The café has welcomed its first customer. Basic movement and behaviour are being developed using a Finite State Machine (FSM), allowing the customer to transition between Idle and Moving states.

There have been some complications with the seating arrangements.

Reginald has been informed.

AI Implementation:

- Finite State Machine (FSM)
- Idle and Moving states
- Distance checking using Vector3.Distance()
- State transitions based on the customer's distance from their destination

Problems Encountered:

 - The customer initially moved towards the chair before reaching the till. This highlighted a problem with how the destination and state changes were being handled.


Next Steps

 - Continue developing the customer's behaviour.


*Record 002: A Queueing lesson*
----------------------------------------

the Cafe's new customer had a concerning habit of walking straight towards the till, regardless of who happens to be standing in the way.

Apparently, queuing etiuettte doesn't come installed in everyone.

A Box sensor has now been introduced, this allows the customer to detect others and respond accordingly. After several unsuccessful attempts, the customer can finally recognise when someone is in front of them and moes towards the back of the queue.

Reginald has been informed.

AI implementation:

 - Agent sensor that used Physics.CheckBox()
 - Customer detection layer.
 - Sensor intergration along side exisiting FSM.
 - Destination changes towards a designated queue position.


 Problems encountered:

  - the sensor initally failed. Increased the detection box range which resolved the issue.
  - the customer stopped moving when detecting another scustomer. This was fixed by adjusting the movement conditions.


next steps:

 - Refine queue position.
 - Teach customers to advance once served / queue moves.
 - Continue developiong customer decision-mkaing,.


*Record 003: McBrista's First Shift: GOAP  *
----------------------------------------

McBrista has finally managed to make and deliver a coffee. Took a few attempts and 29 errors, but we got there.

AI Implementation:
 - Implemented a basic backward GOAP planner using arrays to store actions, preconditions and effects.
 - Used world-state variables to check whether orders have been taken and coffee is ready.
 - Connected the planner to McBrista's movement so he can carry out the selected actions.
 - Tested skipping the order-taking action when an order has already been placed.
 - Used Vector3.MoveTowards() and invisible GameObjects for destinations.

Problems encountered:
 - Several misplaced brackets caused 29 errors.
 - Naming inconsistencies stopped certain actions from completing.
 - Debugging helped identify why coffee delivery wasn't being recorded.

Evaluation:
 - Although GOAP works for McBrista, I'm questioning whether it's the best choice for his role.
 - His tasks are fairly predictable, and an FSM or Behaviour Tree could probably handle them with less complexity. GOAP might be better suited to a café employee with several different jobs, where the AI needs to decide what to do depending on the situation.

Next steps:
 - Test the alternative CollectCoffee action ot adding another order.
 - Investigate Behaviour Trees as a possible alternative for McBrista.
 - Consider using GOAP for an NPC with more varied responsibilities.

Limitations / Future Improvements:
 - McBrista can plan the actions needed to complete an order, but doesn't calculate which approach is the most efficient.
 - Action costs haven't been implemented, so he can't compare different plans based on time or effort.
 - The planner only runs at the start. If something changes halfway through, McBrista won't adjust his plan.
 - GOAP might be better suited to an NPC with more varied jobs. For McBrista's fairly predictable routine, a Behaviour Tree or FSM could be better suited for extra contol over NPC actions.

 GOAP might be better suited to an NPC with more varied jobs. For McBrista's fairly predictable routine, a Behaviour Tree or FSM could be simplerMcBrista has finally managed to make and deliver a coffee. Took a few attempts and 29 errors, but we got there.

CMP6206 week 7 - GOAP: goals, Actions, Preconditions, effects and Planning.
https://learn.unity.com/tutorial/arrays-9o
https://learn.unity.com/tutorial/loops-z2b
https://learn.unity.com/course/beginner-scripting
https://docs.unity.com/en-us/engine/6000.0/script-reference/unityengine/time/deltatime
https://docs.unity.com/en-us/engine/6000.0/script-reference/unityengine/serializefield
https://docs.unity.com/en-us/engine/6000.0/script-reference/unityengine/vector3/movetowards
Accessed on 07/11/2026

CMP6206 week 7, page 8
CMP6206 week 7, page 10
CMP6206 week 7, page 13
Accessed on 08/11/2026

Aversa, D. (2018) 'Choosing between Behavior Tree and GOAP, Davide Aversa, 13 February. Available at: http://davideaversa.it/blog/choosing-behavior-tree-goap-planning/ 
Accessed: 11 November 2026.

*Record 004: Elanor A Matter Of Housekeeping: Behaviour Trees  *
----------------------------------------

Very little escapes Elanor's attention at he Ink & Bone Cafe.

Customers come and go, leaving behind empty cups and the occasional mess. Nothing out fo the ordinary for a cafe. Although, oridanry is hardly a word one would use to describe this palce.

Elanor has always kept a watchful eye on her surroundings, noticing things others tend to ovcerlook. With the introduction of a Behavior Tree, she can now attend to the tables without being instructed. She searches for anything that needs cleaning, approaches the atables, removes the item and quietly returns to her usual position.

Two seperate messes have now been delt with. both without incident.

Reginald appricaited a tidy establishment. After all, there are far more pressing matters requiring his attention.


AI Implementation:
 - Created Elanor's BT using Unity Behavior.
 - Sequence nodes control the order of her actions, while Try In Order decides whether she cleans or remains Idle.
 - Objects tagged NeedsCleaning are recoginised as cleaning targets.
 - Elanor can move towards both targets, clean them and return to her Idle position.
 - Tested.

Problems:
 - Struggled to link Blackboard varibles and correct nodes.
 - Originally Elanor stayed at the same table after cleaning because she hadn't been given a return point / command.
 - Fixed with IdlePoint.

Next steps:
 - Usinge C# scripting to customise acrtions and conditions.
 - Connect cleaning behavior to the customers so they can leave cups behind when leaving.
 - Work on navigation to move around the furniture instead of walking through the.


Sources:

 - CMP6206, Lecture 6: Behaviour Trees (2026). Your university lecture slides, covering Sequence, Fallback, Blackboard variables and action nodes. Accessed on 12/11/2026
 - Unity Technologies – Creating a Behavior Graph https://docs.unity.cn/Packages/com.unity.behavior@1.0/manual/create-behavior-graph Accessed on 12/11/20026
 - Unity Technologies – Behavior Graph Node Types https://docs.unity.cn/Packages/com.unity.behavior@1.0/manual/node-types Accessed on 12/11/2026
 - Millington, I. (2019). AI for Games, 3rd edition. Section 5.4: Behavior Trees Accessed on 12/11/2026


 - *The Method Behind the Madness*

*AI selection and Reasoning *
----------------------------------------