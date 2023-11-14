using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] TextMeshProUGUI _ammoload;
    [SerializeField] GameObject _ammoPrefab;   
    private IGun _gun;

 
    public void SetGun1()
    {
        SetGun(new Gun_1(5));
        _ammoload.text = _gun.GetCount();
    }
    public void SetGun2()
    {
        SetGun(new Gun_2());
        _ammoload.text = _gun.GetCount();
    }
    public void SetGun3()
    {
        SetGun(new Gun_3(15));
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
