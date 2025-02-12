using UnityEngine;

public enum NPCState
{
    Idle,
    Patrol,
    Chase,
    Attack,
}

public class NPC : StateManager<NPCState>
{
    void Awake()
    {
        States[NPCState.Idle] = new IdleState();
        States[NPCState.Patrol] = new PatrolState();
        States[NPCState.Chase] = new ChaseState();
        States[NPCState.Attack] = new AttackState();
    }

    protected override void Start()
    {
        ChangeState(NPCState.Idle);
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    void OnGUI()
    {
        float width = 150;
        float height = 40;

        if (GUI.Button(new Rect(10, 10, width, height), "Switch to Idle"))
        {
            ChangeState(NPCState.Idle);
        }
        if (GUI.Button(new Rect(10, 60, width, height), "Switch to Patrol"))
        {
            ChangeState(NPCState.Patrol);
        }
        if (GUI.Button(new Rect(10, 110, width, height), "Switch to Chase"))
        {
            ChangeState(NPCState.Chase);
        }
        if (GUI.Button(new Rect(10, 160, width, height), "Switch to Attack"))
        {
            ChangeState(NPCState.Attack);
        }
    }
}
