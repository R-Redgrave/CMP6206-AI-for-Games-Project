
using UnityEngine;

public class MovingState : State
{
    Customer_01 owner;

    public MovingState(Customer_01 owner)
    {
        this.owner = owner;
    }

    public override void Enter()
    {
        Debug.Log("Entering Moving");
    }

    public override void Execute()
    {
        if (owner.seek_me == null)
            return;

        Vector3 direction = owner.seek_me.transform.position
                            - owner.transform.position;

        direction.y = 0f;

        if (direction.magnitude > 0.5f)
        {
            owner.transform.Translate(
                direction.normalized * owner.speed * Time.deltaTime,
                Space.World
            );
        }
    }

    public override void Exit()
    {
        Debug.Log("Exiting Moving");
    }
}
