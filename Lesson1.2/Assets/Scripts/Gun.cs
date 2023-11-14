using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IGun
{

    static int ammoMax = 5;
    private int ammo = ammoMax;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string GetCount()
    {
        return "12";
    }
    // Update is called once per frame
    void Update()
    {
        
    }



    public void Reload() => ammo = ammoMax;

    public void Fire(Transform target, GameObject ammo)
    {

    }
    public void Hold()
    { }



}

