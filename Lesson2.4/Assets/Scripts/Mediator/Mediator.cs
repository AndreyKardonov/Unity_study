using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Mediator : MonoBehaviour
{
    private UI_Class _uiClass;
    private Player _player;
    public void Initialize(Player player, UI_Class uiclass)
    {
        _uiClass = uiclass;
        _player = player;
        _player.HPDecrease  += DecreaseHP;
        _player.LVLIncrease += IncreaseLVL;

    }
    private void OnDisable()
    {
        _player.HPDecrease  -= DecreaseHP;
        _player.LVLIncrease -= IncreaseLVL;
    }
    public void DecreaseHP()
    {
        _uiClass.SetHPText(_player.HP.ToString());
        if (_player.HP<=0) 
        {
            _uiClass.ShowRestartCanvas();
            Debug.Log("restart!");
        }
    }

    public void IncreaseLVL()
    {
        _uiClass.SetLVLText(_player.Level.ToString());
    }



}
