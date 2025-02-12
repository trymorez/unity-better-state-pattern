using UnityEngine;

public class ChaseState : BaseState<NPCState>
{
    public ChaseState() : base(NPCState.Chase) { }

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

    public override NPCState GetNextState()
    {
        return NPCState.Chase;
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
