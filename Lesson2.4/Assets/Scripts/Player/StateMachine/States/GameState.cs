using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class GameState : BasePlayerClass
{

    private readonly GameConfig _gameConfig;

    public GameState(IStateSwitcher stateSwitcher, Player player) : base(stateSwitcher, player)
    {
        _gameConfig = player.Config.GameConfig;
 //       StateName = _gameConfig.GameText;
        
    }
    public override void Enter() => base.Enter();
    public override void Exit() => base.Exit();


    public override void Update()
    {
        base.Update();

    }
    protected override void AddInputActionCallback()
    {


    }


    protected override void RemoveInputActionCallback()
    {

    }

 

}
