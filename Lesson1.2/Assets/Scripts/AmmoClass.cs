using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoClass : MonoBehaviour
{
    const int AmmoSpeed = 10;
    public Transform _target;
    public  GameObject _ammo;

    public bool _isFiring = false;
    private void Start()
    {
        Debug.Log("ammo-start");
 //       _isFiring = false;
    }

    public void Fire(Transform target)
    {
        Debug.Log("ammo--ammo--ammo");
        _target = target;
        _isFiring = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ammo-fire-0");
        if (_isFiring == false) return;

        Vector3 direction = _target.position - _ammo.transform.position;
        _ammo.transform.Translate(direction.normalized * AmmoSpeed * Time.deltaTime);
        Debug.Log("ammo-fire-1");

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
