using UnityEngine;
public class Player : MonoBehaviour
{
    private ActorData _actorData;
    private StateMachine _stateMachine;
    private void Start()
    {
        _actorData = GetComponent<ActorData>();
        _stateMachine = new StateMachine();
        _stateMachine.AddState(new Idle(_actorData,_stateMachine));
        _stateMachine.AddState(new Roll(_actorData,_stateMachine));
        _stateMachine.AddState(new Move(_actorData,_stateMachine));
        _stateMachine.AddState(new Fight(_actorData,_stateMachine));
        
        _actorData.UserInput.Player.Move.performed += context => _stateMachine.ChangeState<Move>();
        _actorData.UserInput.Player.Move.canceled += context =>_stateMachine.ChangeState<Idle>();
        _actorData.UserInput.Player.Roll.performed += context => _stateMachine.ChangeState<Roll>();
        _actorData.UserInput.Player.SoftAttack.performed+=context=>_stateMachine.ChangeState<Fight>();
        _actorData.UserInput.Player.StrongAttack.performed+=context=>_stateMachine.ChangeState<Fight>();
        _stateMachine.Initialize<Idle>();
    }
    private void Update()
    {
        _stateMachine.CurrentState.LogicUpdate();
    }
    private void FixedUpdate() 
    {
        _stateMachine.CurrentState.PhysicsUpdate();
    }
}

