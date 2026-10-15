
using UnityEngine;
using UnityEngine.Rendering;

public class Customer_01 : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject seek_me;
    public GameObject chair;
    public customer_Sensor sensor;
    public bool detected;
    public GameObject queueBack;
    bool joiningQueue = false;

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

        if (sensor != null && sensor.detected && !joiningQueue && seek_me != chair && queueBack != null) // joins queue
        {
            seek_me = queueBack;
            joiningQueue = true;
        } // joins queue

        float distance = Vector3.Distance(
            transform.position,
            seek_me.transform.position
        );

        if (distance > 0.2f && !state_change)
        {
            sm.ChangeState(new MovingState(this));
            state_change = true;
        }

        if (distance <= 0.2f && state_change)
        {
            sm.ChangeState(new Idle_State(this));
            state_change = false;

            //Customer has reached the till
            if (!joiningQueue && seek_me != chair && chair != null)
            {
                seek_me = chair;
            }
        }
    }
}
