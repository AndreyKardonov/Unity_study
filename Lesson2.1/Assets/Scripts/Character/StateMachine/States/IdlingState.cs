using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class IdlingState : BasePlayerClass
{

    private readonly IdleConfig _idleConfig;
    public IdlingState(IStateSwitcher stateSwitcher, Player player) : base(stateSwitcher, player)
    {
        _idleConfig = player.Config.IdleConfig;
        StateName = _idleConfig.IdleText;
        
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
        Input.Movement.Work.started += base.GoWork;
        Input.Movement.Sing.started += base.GoSing;
        Input.Movement.Run.started += base.GoRun;

    }


    protected override void RemoveInputActionCallback()
    {
        base.RemoveInputActionCallback();
        Input.Movement.Work.started -= base.GoWork;
        Input.Movement.Sing.started -= base.GoSing;
        Input.Movement.Run.started -= base.GoRun;
    }

 

}
