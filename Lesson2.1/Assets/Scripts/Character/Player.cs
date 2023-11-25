using UnityEngine;

[RequireComponent (typeof (CharacterController))]

public class Player : MonoBehaviour
{

    [SerializeField] private RootStateConfig _rootStateConfig;
    private PlayerInput _input;
    private CharacterStateMachine _stateMachine;
    private CharacterController _playerController;

    public PlayerInput Input => _input;
    public CharacterController Controller => _playerController;
    public RootStateConfig Config => _rootStateConfig;


    private void Awake()
    {
        _playerController = GetComponent<CharacterController>();
        _input = new PlayerInput();
        _stateMachine = new CharacterStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.HandleInput();
        _stateMachine.Update();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();

}
