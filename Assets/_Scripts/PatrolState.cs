using UnityEngine;

public class PatrolState : BaseState<ChaserState>
{
    public PatrolState() : base(ChaserState.Patrol) { }

    public override void EnterState()
    {
        Debug.Log("Entering Patrol");
    }

    public override void UpdateState()
    {
        Debug.Log("Updating Patrol");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Patrol");
    }

    public override ChaserState GetNextState()
    {
        return ChaserState.Patrol;
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
