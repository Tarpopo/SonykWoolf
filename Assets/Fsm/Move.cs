using UnityEngine;
public class Move : State
{
    private MoveElement _currentMove;
    public Move(ActorData data,StateMachine stateMachine) : base(data,stateMachine)
    {
        _currentMove = Data.MoveElements[0];
        Data.UserInput.Player.Run.performed += context => _currentMove = Data.MoveElements[1];
        Data.UserInput.Player.Run.canceled += context => _currentMove = Data.MoveElements[0];
    }

    public override void LogicUpdate()
    {
        var horizontal = Data.UserInput.Player.Move.ReadValue<Vector2>().normalized;
        Data.SetLookDirection();
        Data.RigidBody.MovePosition(Data.RigidBody.position+horizontal*_currentMove.MoveSpeed);
        Data.Anim.Play(Data.IsFight?Data.WalkFight:_currentMove.Move.name);
    }
}
