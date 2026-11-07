using UnityEngine;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tillPoint != null && ordertaken == false) // checking destination has been assigned
        {
            transform.position = Vector3.MoveTowards /* moves Mcbrista toward the destination */ 
                (transform.position,
                  tillPoint.position, 
                  speed * Time.deltaTime
                );
        }

        if (Vector3.Distance(transform.position, tillPoint.position) < 0.2f && ordertaken == false)
        {
            waitTimer += Time.deltaTime;

            if (waitTimer >= waittime)
            {
                ordertaken = true;
                Debug.Log("Mcbristia: Order taken!");
            }
        }

        if (CoffeePoint != null && ordertaken == true) // checking destination has been assigned
        {
            transform.position = Vector3.MoveTowards /* moves Mcbrista toward the destination */
                (transform.position,
                  CoffeePoint.position,
                  speed * Time.deltaTime
                );
        }
    }
}
/*GOAP Goal: Serve the customer coffee.

Actions Mcbrista can choose:
1. Take the customer's order.
2. Make the coffee.
3. Deliver the coffee.*/