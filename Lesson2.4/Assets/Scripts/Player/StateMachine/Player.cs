using UnityEngine;
using UnityEngine.TextCore.Text;

[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{

    [SerializeField] private RootStateConfig _rootStateConfig;
    private PlayerInput _input;
    private CharacterStateMachine _stateMachine;
    private CharacterController _playerController;

    public PlayerInput Input => _input;
    public CharacterController Controller => _playerController;
    public RootStateConfig Config => _rootStateConfig;
    private int _speed;

    private Quaternion TurnRight => new Quaternion(0, 0, 0, 0);
    private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);


    private void Awake()
    {
        _playerController = GetComponent<CharacterController>();
        _input = new PlayerInput();
        _stateMachine = new CharacterStateMachine(this);


    }

    private void Update()
    {
        //      _stateMachine.HandleInput();
        //      _stateMachine.Update();
        _speed = Config.GameConfig.Speed;


        Vector3 velocity = new Vector3(_speed * ReadHorizontalInput(), 0, 0);

        _playerController.Move(velocity * Time.deltaTime);
        transform.rotation = GetRotationFrom(velocity);



    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();


    private Quaternion GetRotationFrom(Vector3 velocity)
    {
        if (velocity.x > 0)
            return TurnRight;

        if (velocity.x < 0)
            return TurnLeft;

        return transform.rotation;
    }

    private float ReadHorizontalInput() => Input.Movement.PlayerMove.ReadValue<float>();




    private void OnCollisionEnter(Collision collision)
    {
        //      if (collision.gameObject.name == "NPC")

        Debug.Log("collision  start");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("collision  end");
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("collision - start" + hit.gameObject.name.ToString());
        
    }
}