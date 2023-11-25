using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingState : BasePlayerClass
{
    private readonly WorkingConfig _workingConfig;

    public WorkingState(IStateSwitcher stateSwitcher, Player player) : base(stateSwitcher, player)
    {
        _workingConfig = player.Config.WorkingConfig;
        StateName = _workingConfig.WorkText;
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
        Input.Movement.Sing.started += base.GoSing;
    }


    protected override void RemoveInputActionCallback()
    {
        base.RemoveInputActionCallback();
        Input.Movement.Idle.started -= base.GoIdle;
        Input.Movement.Sing.started -= base.GoSing;
    }



}
