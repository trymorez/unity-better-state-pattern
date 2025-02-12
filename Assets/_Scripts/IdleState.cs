using UnityEngine;

public class IdleState : BaseState<NPCState>
{
    public IdleState() : base(NPCState.Idle) { }

    public override void EnterState()
    {
        Debug.Log("Entering Idle");
    }

    public override void UpdateState()
    {
        Debug.Log("Updating Idle");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Idle");
    }

    public override NPCState GetNextState()
    {
        return NPCState.Idle;
    }

    public override void OnTriggerEnter(Collider other)
    {
    }

    public override void OnTriggerExit(Collider other)
    {
    }

    public override void OnTriggerStay(Collider other)
    {
    }
}
