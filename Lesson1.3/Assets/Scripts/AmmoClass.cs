using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoClass : MonoBehaviour
{
    const int AmmoSpeed = 10;
    public Transform _target;
    public  GameObject _ammo;

    public bool _isFiring = false;


    public void Fire(Transform target)
    {
        _target = target;
        _isFiring = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isFiring == false) return;

        Vector3 direction = _target.position - _ammo.transform.position;
        _ammo.transform.Translate(direction.normalized * AmmoSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
