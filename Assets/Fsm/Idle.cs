using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Idle(ActorData data, StateMachine stateMachine) : base(data, stateMachine)
    {
    }

    public override void Enter()
    {
        Data.Anim.Play(Data.IsFight?Data.IdleFight:"Idle");
    }
}
