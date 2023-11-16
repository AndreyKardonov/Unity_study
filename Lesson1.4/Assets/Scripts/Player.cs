using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] TextMeshProUGUI _ammoload;
    [SerializeField] GameObject _ammoPrefab;
    private IGun _gun;


    public void SetGunS(int _nGun)
    {
        switch (_nGun)
        {
            case 1:
                SetGun(new Gun_1(5));
                break;
            case 2:
                SetGun(new Gun_2());
                break;
            case 3:
                SetGun(new Gun_3(15));
                break;
            default:
                SetGun(new Gun_1(5));
                break;
        }
        _ammoload.text = _gun.GetCount();
    }



    public void Fire()
    {
        _gun.Fire(_target, _ammoPrefab);
        _ammoload.text = _gun.GetCount();
    }
    public void Reload()
    {
        _gun.Reload();
        _ammoload.text = _gun.GetCount();
    }

    // private section
    private void Start()
    {
        SetGun(new Gun_1(5));
        _ammoload.text = _gun.GetCount();
    }
    private void SetGun(IGun igun)
    {
        _gun = igun;
    }
}
