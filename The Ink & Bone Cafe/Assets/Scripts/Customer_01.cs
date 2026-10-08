
using UnityEngine;
using UnityEngine.Rendering;

public class Customer_01 : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject seek_me;
    public GameObject chair;

    State_Manager sm = new State_Manager();
    bool state_change = false;

    void Start()
    {
        sm.ChangeState(new Idle_State(this));
    }

    void Update()
    {
        sm.Update();

        if (seek_me == null)
            return;

        float distance = Vector3.Distance(
            transform.position,
            seek_me.transform.position
        );

        if (distance > 5.0f && !state_change)
        {
            sm.ChangeState(new MovingState(this));
            state_change = true;
        }

        if (distance <= 2.0f && state_change)
        {
            sm.ChangeState(new Idle_State(this));
            state_change = false;

            //Customer has reached the till
            if (seek_me != chair && chair != null)
            {
                seek_me = chair;
            }
        }
    }
}
