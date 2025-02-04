using System.Net.NetworkInformation;
using UnityEngine;

public enum ChaserState
{
    Idle,
    Patrol,
    Chase,
    Attack,
}

public class Chaser : StateManager<ChaserState>
{
    void Awake()
    {
        States[ChaserState.Idle] = new IdleState();
        States[ChaserState.Patrol] = new PatrolState();
        States[ChaserState.Chase] = new ChaseState();
        States[ChaserState.Attack] = new AttackState();
    }

    protected override void Start()
    {
        ChangeState(ChaserState.Idle);
        base.Start();
    }

    protected override void Update()
    {
        HandleInput();
        base.Update();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // '1' key
        {
            ChangeState(ChaserState.Idle);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // '2' key
        {
            ChangeState(ChaserState.Patrol);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // '3' key
        {
            ChangeState(ChaserState.Chase);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) // '4' key
        {
            ChangeState(ChaserState.Attack);
        }
    }
}
