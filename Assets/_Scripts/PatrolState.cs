using UnityEngine;

public class PatrolState : BaseState<NPCState>
{
    public PatrolState() : base(NPCState.Patrol) { }

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

    public override NPCState GetNextState()
    {
        return NPCState.Patrol;
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
