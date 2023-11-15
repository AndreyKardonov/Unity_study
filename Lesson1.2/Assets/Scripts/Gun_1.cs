using UnityEngine;


public class Gun_1:  IGun
{
    private int ammoMax = 5;
    private int ammo;
    private GameObject newAmmo;
    public string GetCount()
    {
        return ammo.ToString() + " / " + ammoMax.ToString();
    }
    public Gun_1(int iniAmmo)
    {
        ammoMax = iniAmmo;
        ammo = ammoMax;
    }

    public void Reload() => ammo = ammoMax;
    public void Fire(Transform target, GameObject _ammoPrefab)
    {
        if (ammo <= 0) return;
       
        ammo--;

        Vector3 ammoPosition1 = new Vector3(0, 0, 0);
        Quaternion ammoRotation = Quaternion.Euler(0, 0, 0);
        newAmmo = GameObject.Instantiate(_ammoPrefab, ammoPosition1, ammoRotation);
        newAmmo.GetComponent<AmmoClass>().Fire(target);
    }

}