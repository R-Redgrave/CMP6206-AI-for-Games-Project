using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class State
{
    public abstract void Enter();

    public abstract void Execute();

    public abstract void Exit();

}
