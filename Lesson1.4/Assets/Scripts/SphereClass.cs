using System;
using UnityEngine;
using UnityEngine.Events;

public class SphereClass : MonoBehaviour 
{
    public Color _color;
    private int _type=0;
   
    public static event Action<int> chpokEvent;
    public Color GetColor() { return _color; }


    static public void CallChpok(int tp)
    {
        chpokEvent.Invoke(tp);
    }
   
    private void Start()
    { 

    }


    public void SetType(int _tp)
    {
        _type = _tp;

        switch (_type)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                break;
            default:
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                break;
        }

 
    }

    public void SetColor(Color _clr)
    {
        _color = _clr;
        gameObject.GetComponent<Renderer>().material.color = _color;

    }
    private void OnMouseDown()
    {
        chpokEvent?.Invoke(_type);
        Destroy(gameObject);
    }

}

