using System;
using UnityEngine.InputSystem;

public class GroundedState : MovementState
{
    private GroundChecker _groundChecker;

    public GroundedState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _groundChecker = character.GroundChecker;

    public override void Enter()
    {
        base.Enter();

        View.StartGrounded();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopGrounded();
    }

    public override void Update()
    {
        base.Update();

        if (_groundChecker.IsTouches == false)
            StateSwitcher.SwitchState<FallingState>();
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        Input.Movement.Jump.started += OnJumpKeyPressed;
        Input.Movement.Speed.started += OnSpeedKeyPressed;
        Input.Movement.Speed.canceled += OnExtraKeyRelease;
        Input.Movement.Slow.started += OnSlowKeyPressed;
        Input.Movement.Slow.canceled += OnExtraKeyRelease;
    }



    protected override void RemoveInputActionsCallback()
    {
        base.RemoveInputActionsCallback();

        Input.Movement.Jump.started -= OnJumpKeyPressed;
        Input.Movement.Speed.started -= OnSpeedKeyPressed;
        Input.Movement.Slow.started -= OnSlowKeyPressed;
        Input.Movement.Slow.started -= OnSlowKeyPressed;
        Input.Movement.Slow.canceled -= OnExtraKeyRelease;

    }

    private void OnJumpKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<JumpingState>();
    private void OnSpeedKeyPressed(InputAction.CallbackContext context) => StateSwitcher.SwitchState<SpeedRunningState>();
    private void OnSlowKeyPressed(InputAction.CallbackContext context) => StateSwitcher.SwitchState<SlowRunningState>();
    private void OnExtraKeyRelease(InputAction.CallbackContext context) => StateSwitcher.SwitchState<RunningState>();


}
