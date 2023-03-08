using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : State
{
    public Patrol(StateManager sm) : base(sm)
    {
        nameOfState = Constants.STATE_PATROL;
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Enter patrol");
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log("Exit patrol");
    }
}
