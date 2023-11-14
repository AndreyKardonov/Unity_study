using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform _target;
    [SerializeField] IGun _gun;
    public GameObject _ammoPrefab;
    public GameObject _gunn;
    // Update is called once per frame
    [SerializeField] TextMeshProUGUI _ammoload;



    public void SetGun1()
    {
        SetGun(new Gun_1());
        _ammoload.text = _gun.GetCount();
    }
    public void SetGun2()
    {
        SetGun(new Gun_2());
        _ammoload.text = _gun.GetCount();
    }

    private void Start()
    {
        SetGun(new Gun_1());
        _ammoload.text = _gun.GetCount();

    }
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Fire!");
            Fire();
        }


    }
    
    public void SetGun(IGun igun)
    {
        _gun?.Hold(); 
        _gun = igun;

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


}
