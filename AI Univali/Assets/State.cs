using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    state currentState = state.IDLE;

    public void ChangeState(state newState)
    {
        if (newState == currentState)
            return;

        currentState = newState;
        Debug.Log(currentState.ToString());
    }

    public state GetEntetyState() => currentState;
}

public enum state { IDLE, COMBAT, RUNOVER, RUNOFF };
