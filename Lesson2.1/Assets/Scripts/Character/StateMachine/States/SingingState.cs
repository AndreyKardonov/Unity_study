using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingingState : BasePlayerClass
{
    private readonly SinginigConfig _singingConfig;

    public SingingState(IStateSwitcher stateSwitcher, Player player) : base(stateSwitcher, player)
    {
        _singingConfig = player.Config.SingingConfig;
        StateName = _singingConfig.SingingText;
    }
    public override void Enter() => base.Enter();
    public override void Exit() => base.Exit();

    public override void Update()
    {
        base.Update();

    }

    protected override void AddInputActionCallback()
    {
        base.AddInputActionCallback();
        Input.Movement.Idle.started += base.GoIdle;
        Input.Movement.Work.started += base.GoWork;
    }


    protected override void RemoveInputActionCallback()
    {
        base.RemoveInputActionCallback();
        Input.Movement.Idle.started -= base.GoIdle;
        Input.Movement.Work.started -= base.GoWork;
    }


}

