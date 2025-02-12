using UnityEngine;

public class AttackState : BaseState<NPCState>
{
    public AttackState() : base(NPCState.Attack) { }

    public override void EnterState()
    {
        Debug.Log("Entering Attack");
    }

    public override void UpdateState()
    {
        Debug.Log("Updating Attack");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Attack");
    }

    public override NPCState GetNextState()
    {
        return NPCState.Attack;
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
