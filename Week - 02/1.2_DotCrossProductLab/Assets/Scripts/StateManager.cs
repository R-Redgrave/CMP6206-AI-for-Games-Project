using JetBrains.Annotations;
using UnityEngine;

public class StateManager
{
    State currState;
    
    public void ChangeState(State newState)
    {
        if (currState != null)
        {
            currState.Exit(); 
        }
       currState = newState;
       newState.Enter();
    }
    
    public void Update()
    {
        if (currState != null) currState.Execute();
    }
}
