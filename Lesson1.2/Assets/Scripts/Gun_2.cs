using UnityEngine;


public class Gun_2: MonoBehaviour, IGun
{
    public string GetCount()
    {
        return  "∞ / ∞";
    }
    public Gun_2()
    {
    }
    public void Reload() { }
    public void Fire(Transform target, GameObject _ammoPrefab)
    {
        Quaternion ammoRotation = Quaternion.Euler(0, 0, 0);
        Vector3 ammoPosition1 = new Vector3(0, 0, 0);
        GameObject newAmmo1 = Instantiate(_ammoPrefab, ammoPosition1, ammoRotation);
        newAmmo1.GetComponent<AmmoClass>().Fire(target);
 
    }



}