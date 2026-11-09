using UnityEngine;

/*GOAP Goal: Serve the customer coffee.

Actions Mcbrista can choose:
1. Take the customer's order.
2. Make the coffee.
3. Deliver the coffee.

Backward planner if coffee not made
 Plan [2] = TakeOrder
 Plan [1] = Makecoffee
 Plan [0] = Delivercoffee

/*Backward planner if coffee made
 Plan [2] = TakeOrder
 Plan [1] = CollectCoffee
 Plan [0] = Delivercoffee */

public class Mcbrista_AI : MonoBehaviour
{
    // Please tidy up your code!
    // where McBrista needs to go
    public Transform tillPoint; // Stores Mcbrista needs to go
    public Transform CoffeePoint;

    //McBrista speed
    public float speed = 2f; // movement speed

    //World State
    public bool ordertaken = false;
    public bool coffeeReady = false;
    public bool coffeeMade = false;
    public bool coffeeDelivered = false;

    // McBrista waiting time
    public float waitTimer = 0f;
    public float waittime = 3f;
    //next step: coffee-making timer.

    //Declare varibles for GOAP 
    //Actions McBrista knows
    string[] actions = { "TakeOrder", "MakeCoffee", "CollectCoffee", "DeliverCoffee" };

    //What eaction action needs
    string[] needs = { "", "ordertaken", "ordertaken", "coffeeMade" };

    //what each action is achiving
    string[] effects = { "ordertaken", "coffeeMade", "coffeeMade", "coffeeDelivered" };

    //Mcbrista plan
    string[] plan = new string[3];
    int step = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GOAP planner
        //Goal: to deliver coffee to the customer
        string needed = "coffeeDelivered"; // Green squiggles aren't errors but suggestions. A variable that has been declared but not used yet.

        //Actions added to the plan
        int count = 0;

        //This will check if the job has been completed. If completed the brista will stop planning.
        while (needed != "" && count < 3)
        {
            if (needed == "coffeeDelivered" && coffeeDelivered) break;
            if (needed == "coffeeMade" && coffeeMade) break;
            if (needed == "orderTaken" && ordertaken) break;
        

        bool found = false;

        for (int i = 0; i < actions.Length; i++)
        {
            //
            if (effects[i] == needed)
            {
                //Skip making coffee if one is ready made.
                if (actions[i] == "MakeCoffee" && coffeeReady) // Mcbrista_AI is checking the coffee!
                    continue;
                //skip collection coffee if not made
                if (actions[i] == "collectCoffee" && !coffeeReady)
                    continue;

                //store action in plan
                plan[count] = actions[i];

                //Increase the number of planned actions
                count++;

                //check what McBrista needs to do before this aciton
                needed = needs[i];

                //McBrista found and action that works
                found = true;

                //stops checking other actions in plan
                break;

            }
        }
            //Stop if McBrista can't find a suitable action
            if (found == false)
                break;
        }
            //Plan was stored backwards
            step = count - 1;
    }
    // Update is called once per frame
    void Update()
    {

        //Plan for McBrista to follow.
        //Are there anymore actions to deliver the coffee or has Mcbrista delivered and can stop?
        if (step < 0 || coffeeDelivered)
            return;

        // Mcbrista will check which action needs to move to next.
        string action = plan[step];

        //Mcbrista will head to the till unless he needs to be at the coffee machine.
        Transform destination = tillPoint;


        if (action == "MakeCoffee" || action == "CoffeeCollect")
        {
            destination = CoffeePoint;
        }

        if (destination == null)
            return;

        transform.position = Vector3.MoveTowards
        (
            transform.position,
            destination.position,
            speed*Time.deltaTime
        );


        //Is Mcbrista close enough to the destination?
        if (Vector3.Distance(transform.position, destination.position) < 0.2f)
        {
            waitTimer += Time.deltaTime;

            if (waitTimer >= waittime)
            {
                if (action == "TakeOrder")
                    ordertaken = true;

                if (action == "MakeCoffee")
                    coffeeMade = true;

                if (action == "CollectCoffee")
                {
                    coffeeMade = true;
                    coffeeReady = false;
                }
                if (action == "DeliverCoffee")
                {
                    coffeeDelivered = true;
                    Debug.Log("Mcbrista completed " + action);
                }


                //Indicates job is complete and can move to the next action.
                waitTimer = 0f;
                    step--;
            }
        }
        ////McBrista walks to the till
        //if (tillPoint != null && ordertaken == false) // has destination been assigned?
        //{
        //    transform.position = Vector3.MoveTowards // moves Mcbrista to the destination  
        //        (transform.position,
        //          tillPoint.position, 
        //          speed * Time.deltaTime
        //        );
        //}

        ////McBrista takes the order
        //if (Vector3.Distance(transform.position, tillPoint.position) < 0.2f && ordertaken == false)
        //{
        //    waitTimer += Time.deltaTime;

        //    if (waitTimer >= waittime)
        //    {
        //        ordertaken = true;
        //        Debug.Log("Mcbristia: Order taken!");
        //    }
        //}

        ////Order taken. McBrista relectantly heads to the coffee machine.
        //if (CoffeePoint != null && ordertaken == true) // has destination been assigned?
        //{
        //    transform.position = Vector3.MoveTowards // moves Mcbrista to the destination
        //        (transform.position,
        //          CoffeePoint.position,
        //          speed * Time.deltaTime
        //        );
        //}
    }
}