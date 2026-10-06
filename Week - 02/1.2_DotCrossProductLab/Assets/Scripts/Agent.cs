using UnityEngine;

public class Agent : MonoBehaviour
{
    StateManager sm = new StateManager();
    bool state_change = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sm.ChangeState(new IdleState(this));
    }

    // Update is called once per frame
    void Update()
    {
        sm.Update();
        if (this.transform.position.x > 5.0f && !state_change)
        {
            sm.ChangeState(new FleeState(this));
            state_change = !state_change;
        }
        if (this.transform.position.x < 5.0f && state_change)
        {
            sm.ChangeState(new IdleState(this));
            state_change = !state_change;
        }
    
    }
}
