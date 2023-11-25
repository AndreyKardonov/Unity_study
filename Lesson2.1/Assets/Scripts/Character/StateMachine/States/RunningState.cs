using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningState : BasePlayerClass
{
    private readonly RunningConfig _runningConfig;
    public RunningState(IStateSwitcher stateSwitcher, Player player) : base(stateSwitcher, player)
    {
        _runningConfig = player.Config.RunningConfig;
        StateName = _runningConfig.RunningText;
    }

public override void Update()
{
    base.Update();

}

    public override void Enter() => base.Enter();
    public override void Exit() => base.Exit();

    protected override void AddInputActionCallback()
    {
        base.AddInputActionCallback();
        Input.Movement.Idle.started += base.GoIdle;
    }


    protected override void RemoveInputActionCallback()
    {
        base.RemoveInputActionCallback();
        Input.Movement.Idle.started -= base.GoIdle;
    }

}
