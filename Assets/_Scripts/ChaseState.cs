using UnityEngine;

public class ChaseState : BaseState<ChaserState>
{
    public ChaseState() : base(ChaserState.Chase) { }

    public override void EnterState()
    {
        Debug.Log("Entering Chase");
    }

    public override void UpdateState()
    {
        Debug.Log("Updating Chase");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Chase");
    }

    public override ChaserState GetNextState()
    {
        return ChaserState.Chase;
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
