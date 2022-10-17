using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class Roll : State
{
    private Timer _rollTimer;
    public Roll(ActorData data,StateMachine stateMachine) : base(data,stateMachine)
    {
        _rollTimer = new Timer();
    }

    public override void PhysicsUpdate()
    {
        _rollTimer.UpdateTimer();
    }

    public override bool IsStatePlay()
    {
        return _rollTimer.IsTick;
    }
    public override void Enter()
    {
        var direction = Data.UserInput.Player.Move.ReadValue<Vector2>().magnitude>0?
            Data.UserInput.Player.Move.ReadValue<Vector2>():
            Vector2.right*Data.transform.localScale.x;

        _rollTimer.StartTimer(Data.RollTime,() =>
        {
            Data.RigidBody.velocity = Vector2.zero;
            if(Data.UserInput.Player.Move.ReadValue<Vector2>().magnitude>0) Machine.ChangeState<Move>();
            else Machine.ChangeState<Idle>();
        });
        Data.Anim.Play("Roll");
        Data.RigidBody.AddForce(direction * Data.RollForce,ForceMode2D.Impulse);
    }

    // public override void Exit()
    // {
    //     Data.SetLookDirection();
    // }
}
