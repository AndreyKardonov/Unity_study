using UnityEngine;

[RequireComponent (typeof (CharacterController))]

public class Player : MonoBehaviour
{
 
    private PlayerInput _input;
    private CharacterStateMachine _stateMachine;
    private CharacterController _playerController;

    public PlayerInput Input => _input;
    public CharacterController Controller => _playerController;
    private void Awake()
    {
        _playerController = GetComponent<CharacterController>();
        _input = new PlayerInput();
        _stateMachine = new CharacterStateMachine();
    }

    private void Update()
    {
        _stateMachine.HandleInput();
        _stateMachine.Update();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();

}
