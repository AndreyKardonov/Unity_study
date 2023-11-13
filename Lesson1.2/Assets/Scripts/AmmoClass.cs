using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoClass : MonoBehaviour
{
    const int AmmoSpeed= 10;
    public Transform _target;
    [SerializeField] GameObject _ammo;
    


    public AmmoClass(Transform target)
    {
        _target = target;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 direction = _target.position - _ammo.transform.position;
        _ammo.transform.Translate(direction.normalized * AmmoSpeed * Time.deltaTime);

    }
}
