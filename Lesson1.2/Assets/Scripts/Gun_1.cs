using UnityEngine;

public class Gun_1: IGun
{
    private Transform _target;

    private bool _isFiring;
    private AmmoClass _ammo;


    public void Fire(Transform target)
    {
        _target = target;
        _isFiring = true;
        _ammo = new AmmoClass(_target);
    }
  

    public void Hold() => _isFiring = false;

    public void Update(float deltaTime)
    {
        if (_isFiring == false)
            return;

//        Vector3 direction = _target.position - _movable.Transform.position;
 //       _movable.Transform.Translate(direction.normalized * _movable.Speed * deltaTime);
    }
}