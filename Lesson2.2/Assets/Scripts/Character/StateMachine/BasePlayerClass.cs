using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasePlayerClass : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    private readonly Player _player;


    protected PlayerInput Input =>  _player.Input;
    protected CharacterController Controller => _player.Controller;
    protected bool StateShow;
    protected string StateName;
    public BasePlayerClass(IStateSwitcher stateSwitcher, Player player)
    {
        StateSwitcher = stateSwitcher;
        _player = player;
        StateShow = false;
 
    }

    public virtual void Enter()
    {
        StateShow = true;
        AddInputActionCallback();


    }


    public virtual void Exit()
    {
        StateShow = false;
        RemoveInputActionCallback();

    }


    public virtual void HandleInput()
    { 
        
    }

    public virtual void Update()
    {
        if (StateShow)
        {
            StateShow = false;
            Debug.Log(StateName);
        }
    }


    protected virtual void AddInputActionCallback()  { }

    protected virtual void RemoveInputActionCallback() { }

    protected void GoRun(InputAction.CallbackContext context)  => StateSwitcher.SwitchState<RunningState>();
    protected void GoSing(InputAction.CallbackContext context) => StateSwitcher.SwitchState<SingingState>();
    protected void GoWork(InputAction.CallbackContext context) => StateSwitcher.SwitchState<WorkingState>();
    protected void GoIdle(InputAction.CallbackContext context) => StateSwitcher.SwitchState<IdlingState>();

}
