using UnityEngine;
using System;
using System.Collections.Generic;

public abstract class StateManager<EState> : MonoBehaviour where EState : Enum
{
    protected Dictionary<EState, BaseState<EState>> States = new();
    protected BaseState<EState> CurrentState;

    protected bool IsChangingState = false;

    protected virtual void Start()
    {
    }

    protected virtual void Update()
    {
        EState nextStateKey = CurrentState.GetNextState();

        if (!IsChangingState && nextStateKey.Equals(CurrentState.StateKey))
        {
            CurrentState.UpdateState();
        }
        else if (!IsChangingState)
        {
            ChangeState(nextStateKey);
        }
    }

    public void ChangeState(EState stateKey)
    {
        IsChangingState = true;
        CurrentState?.ExitState();
        CurrentState = States[stateKey];
        CurrentState?.EnterState();
        IsChangingState = false;
    }

    void OnTriggerEnter(Collider other)
    {
        CurrentState.OnTriggerEnter(other);
    }

    void OnTriggerStay(Collider other)
    {
        CurrentState.OnTriggerStay(other);
    }

    void OnTriggerExit(Collider other)
    {
        CurrentState.OnTriggerExit(other);
    }
}
