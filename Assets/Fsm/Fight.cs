using UnityEngine.InputSystem;

public class Fight : State
{
    public Fight(ActorData data, StateMachine stateMachine) : base(data, stateMachine)
    {
    }

    public override void LogicUpdate()
    {
        if(Data.UserInput.Player.Move.phase == InputActionPhase.Started) Machine.ChangeState<Move>();
    }

    public override bool IsStatePlay()
    {
        return Data.IsAttack;
    }
}
