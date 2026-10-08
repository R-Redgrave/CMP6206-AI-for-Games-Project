
using UnityEngine;

public class Idle_State : State
{
    Customer_01 owner;

    public Idle_State(Customer_01 owner)
    {
        this.owner = owner;
    }

    public override void Enter()
    {
        Debug.Log("Entering Idle");
    }

    public override void Execute()
    {
        // Customer waits
    }

    public override void Exit()
    {
        Debug.Log("Exiting Idle");
    }
}
