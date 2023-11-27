using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class Player : MonoBehaviour
{
    [SerializeField] private Mediator _mediator;
    [SerializeField] private RootStateConfig _rootStateConfig;
    public PlayerInput Input => _input;
    public CharacterController Controller => _playerController;
    public RootStateConfig Config => _rootStateConfig;  
    public int HP => _hp;
    public int Level => _lvl;  

    public event Action HPChangeEvent;
    public event Action LVLChangeEvent;

    private PlayerInput _input;
    private CharacterController _playerController;
    private int _hp;
    private int _lvl; 
    private int _speed;

    private Quaternion TurnRight => new Quaternion(0, 0, 0, 0);
    private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);



    public void Restart()
    {
        _hp = Config.GameConfig.HP;
        _lvl = Config.GameConfig.Level;
        LVLChangeEvent?.Invoke();
        HPChangeEvent?.Invoke();
    }
    public void StartInput() => OnEnable();

    public void StopInput() => OnDisable();

    public void Initialize()
    {
      _playerController = GetComponent<CharacterController>();
      _input = new PlayerInput();
   
    }


    private void Update()
    {
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

 
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
            if (hit.gameObject.name.ToString() == "CL_HP")
            {
                Debug.Log("collision  HP");
                _hp--;
                HPChangeEvent?.Invoke();
              }
            if (hit.gameObject.name.ToString() == "CL_Level")
            {
                Debug.Log("collision  Level");
                _lvl++;
                LVLChangeEvent?.Invoke();
            }
    }
     


}