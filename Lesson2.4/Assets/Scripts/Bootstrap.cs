using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Mediator _mediator;
    [SerializeField] private UI_Class _uiClass;

    [SerializeField] private Player _player;

    private void Awake()
    {
          _mediator.Initialize(_player, _uiClass);

    
    }


}
