using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerClass : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    private readonly Player _player;


    protected PlayerInput Input =>  _player.Input;
    protected CharacterController Controller => _player.Controller;


    public BasePlayerClass(IStateSwitcher stateSwitcher, Player player)
    {
        StateSwitcher = stateSwitcher;
        _player = player;
    }

    public virtual void Enter()
    {
        
    }

    public virtual void Exit()
    {
      
    }

    public void HandleInput()
    {
        
    }

    public void Update()
    {
        
    }
}
