public class SpeedRunningState : GroundedState
{
    private readonly SpeedRunningStateConfig _config;

    public SpeedRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.SpeedRunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
        Data.Speed = _config.RunningSpeed;
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
