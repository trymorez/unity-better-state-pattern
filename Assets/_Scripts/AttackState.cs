using UnityEngine;

public class AttackState : BaseState<ChaserState>
{
    public AttackState() : base(ChaserState.Attack) { }

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

    public override ChaserState GetNextState()
    {
        return ChaserState.Attack;
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
