using UnityEngine;

public class IdleState : BaseState<ChaserState>
{
    public IdleState() : base(ChaserState.Idle) { }

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

    public override ChaserState GetNextState()
    {
        return ChaserState.Idle;
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
