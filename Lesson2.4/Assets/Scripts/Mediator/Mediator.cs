using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Mediator : MonoBehaviour
{
    private UI_Class _uiClass;
    public void Initialise()
    {
        _uiClass = new UI_Class();

    }

  public void DecreaseHP(string _text)
    {
        _uiClass.SetHPText(_text);

    }

    public void IncreaseLVL(string _text)
    {
        _uiClass.SetLVLText(_text);

    }



}
