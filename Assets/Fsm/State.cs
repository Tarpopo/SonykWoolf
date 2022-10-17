public abstract class State
{
    public readonly StateMachine Machine;
    public readonly ActorData Data;
    protected State(ActorData data,StateMachine stateMachine)
    {
        Machine = stateMachine;
        Data = data;
    }

    public virtual bool IsStatePlay()
    {
        return false;
    }

    public virtual void Enter()
    {
    }
    public virtual void HandleInput()
    {
    }
    public virtual void LogicUpdate()
    {
    }
    public virtual void PhysicsUpdate()
    {
    }
    public virtual void Exit()
    {
    }
}