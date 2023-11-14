using UnityEngine;

public interface IGun
{
    void Fire(Transform _target, GameObject _ammoPrefab);
    void Hold();
    public void Reload();
    public string GetCount();


}