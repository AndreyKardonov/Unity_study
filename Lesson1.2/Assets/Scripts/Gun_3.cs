using UnityEngine;


public class Gun_3: MonoBehaviour, IGun
{
    private int ammoMax = 15;
    private int ammo;

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
        GameObject newAmmo1 = Instantiate(_ammoPrefab, ammoPosition1, ammoRotation);
        newAmmo1.GetComponent<AmmoClass>().Fire(target);
 
        Vector3 ammoPosition2 = new Vector3(0, 0, 0 );
        GameObject newAmmo2 = Instantiate(_ammoPrefab, ammoPosition2, ammoRotation);
        newAmmo2.GetComponent<AmmoClass>().Fire(target);
 
        Vector3 ammoPosition3 = new Vector3(2, 0,0 );
        GameObject newAmmo3 = Instantiate(_ammoPrefab, ammoPosition3, ammoRotation);
        newAmmo3.GetComponent<AmmoClass>().Fire(target);
    }


}