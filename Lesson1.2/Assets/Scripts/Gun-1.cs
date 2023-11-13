using UnityEngine;

public class RandomCoin : GunClass
{
    [SerializeField, Range(0, 50)] private int _maxAmmo;
 

    private void OnValidate()
    {
 
    }

    protected override void Fire()
    {
    }
}