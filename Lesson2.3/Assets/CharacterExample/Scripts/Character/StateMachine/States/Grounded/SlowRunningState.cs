public class SlowRunningState : GroundedState
{
    private readonly SlowRunningStateConfig _config;

    public SlowRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.SlowRunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
        Data.Speed = _config.SlowSpeed;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
