using System;
using UnityEngine;
using UnityEngine.Events;

public class SphereClass : MonoBehaviour 
{
    private int _type=0; // Тип шарика (соответствует цвету в классе MyColors
    public static event Action<int> chpokEvent;  //Событие - на шарик нажали

    static public void CallChpok(int tp)
    {
        chpokEvent.Invoke(tp);
    }


    public void SetType(int _tp, Color _clr)
    {
        _type = _tp;
        gameObject.GetComponent<Renderer>().material.color = _clr;
    }

    private void OnMouseDown()
    {
        chpokEvent?.Invoke(_type);
        Destroy(gameObject);
    }

}

