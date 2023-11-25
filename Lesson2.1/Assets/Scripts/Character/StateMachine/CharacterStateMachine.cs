using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterStateMachine  : IStateSwitcher
{

    private List<IState> _states;
    private IState _currentState;


    public  CharacterStateMachine(Player player)
    {
        _states = new List<IState>()
        {
            new IdlingState(this,player),
            new RunningState(this,player),
            new SingingState(this,player),
            new WorkingState(this,player),

        };
        _currentState = _states[0];
        _currentState.Enter();

    }

    public void SwitchState<State>() where State : IState
    {
       IState state = _states.FirstOrDefault(state => state is State);
        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void HandleInput() => _currentState.HandleInput();

    public void Update() => _currentState.Update();

}
