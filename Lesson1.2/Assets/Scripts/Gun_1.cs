using UnityEngine;


public class Gun_1: MonoBehaviour, IGun
{
    private int ammoMax = 5;
    private int ammo;

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
        GameObject newAmmo1 = Instantiate(_ammoPrefab, ammoPosition1, ammoRotation);
        newAmmo1.GetComponent<AmmoClass>().Fire(target);
    }

}