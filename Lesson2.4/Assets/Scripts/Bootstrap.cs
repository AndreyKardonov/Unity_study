using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Mediator _mediator;
    [SerializeField] private UI_Class _uiClass;
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player.Initialize();
        _mediator.Initialize(_player, _uiClass);
        _player.Restart();  
     }


}
