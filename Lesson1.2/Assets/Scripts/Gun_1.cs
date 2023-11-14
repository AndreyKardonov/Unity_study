using UnityEngine;


public class Gun_1: MonoBehaviour, IGun
{
    private Transform _target;
    static int ammoMax = 5;
    private bool _isFiring;
    private AmmoClass _ammo;
    private int ammo;

    public string GetCount()
    {
        return ammo.ToString() + " / " + ammoMax.ToString();
    }
    public Gun_1()
    {
        ammo = ammoMax;
    }
    public void Reload() => ammo = ammoMax;
    public void Fire(Transform target, GameObject _ammoPrefab)
    {

        if (ammo <= 0) return;

        _target = target;
        ammo--;


        Vector3 ammoPosition = new Vector3(0, 0, 0);
        Quaternion ammoRotation = Quaternion.Euler(0, 0, 0);

        GameObject newAmmo = Instantiate(_ammoPrefab, ammoPosition, ammoRotation);

        newAmmo.GetComponent<AmmoClass>().Fire(target);

    }


    public void Hold()
    { }


}