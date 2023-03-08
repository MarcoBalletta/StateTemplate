using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateManager : MonoBehaviour
{
    public State currentState;
    public Dictionary<string, State> listOfStates = new Dictionary<string, State>();
    //public States states;
    //public List<States> listStates = new List<States>(); 

    public void SetupStates()
    {
        listOfStates.Add(Constants.STATE_PATROL, new Patrol(this));
        listOfStates.Add(Constants.STATE_CHASE, new Chase(this));
    }

    // Start is called before the first frame update
    void Awake()
    {
        SetupStates();
        ChangeState(Constants.STATE_PATROL);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.OnUpdate();

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    ChangeState(Constants.STATE_PATROL);
        //}

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    ChangeState(Constants.STATE_CHASE);
        //}
    }

    public void ChangeState(string key)
    {
        if (currentState.nameOfState == key) return;
        currentState?.OnExit();
        currentState = listOfStates[key];
        currentState?.OnEnter();
    }

    /*public string State
    {
        get => currentState.nameOfState;
        set {
            currentState?.OnExit();
            currentState = listOfStates[value];
            currentState?.OnEnter();
        }
    }*/
}

/*[Flags]
public enum States : byte
{
    patrol = 1,
    chase = 2,
    idle = 4,
}
*/