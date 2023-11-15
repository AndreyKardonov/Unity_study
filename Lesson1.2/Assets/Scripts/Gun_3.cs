using UnityEngine;


public class Gun_3: IGun
{
    private int ammoMax = 15;
    private int ammo;
    private GameObject newAmmo;
    
    public string GetCount()
    {
        return ammo.ToString() + " / " + ammoMax.ToString();
    }
    public Gun_3(int iniAmmo)
    {
        ammoMax = iniAmmo;
        ammo = ammoMax;
    }
    public void Reload() => ammo = ammoMax;
    public void Fire(Transform target, GameObject _ammoPrefab)
    {
        if (ammo <= 0) return;

        ammo-=3;

        Quaternion ammoRotation = Quaternion.Euler(0, 0, 0);

        Vector3 ammoPosition1 = new Vector3(-2, 0, 0);
        newAmmo = GameObject.Instantiate(_ammoPrefab, ammoPosition1, ammoRotation);
        newAmmo.GetComponent<AmmoClass>().Fire(target);
 
        Vector3 ammoPosition2 = new Vector3(0, 0, 0 );
        newAmmo = GameObject.Instantiate(_ammoPrefab, ammoPosition2, ammoRotation);
        newAmmo.GetComponent<AmmoClass>().Fire(target);
 
        Vector3 ammoPosition3 = new Vector3(2, 0,0 );
        newAmmo = GameObject.Instantiate(_ammoPrefab, ammoPosition3, ammoRotation);
        newAmmo.GetComponent<AmmoClass>().Fire(target);
    }


}