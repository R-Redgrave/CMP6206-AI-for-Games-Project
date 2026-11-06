using UnityEngine;

public class Mcbrista_AI : MonoBehaviour
{
    public Transform tillPoint; // Stores Mcbrista needs to go
    public Transform CoffeePoint;
    public float speed = 2f; // movement speed
    public bool ordertaken = false;
    public float waitTimer = 0f;
    public float waittime = 3f;

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