using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Chase : State
{
    public Chase(StateManager sm): base(sm)
    {
        nameOfState = Constants.STATE_CHASE;
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Enter chase");
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log("Exit chase");
    }
}
