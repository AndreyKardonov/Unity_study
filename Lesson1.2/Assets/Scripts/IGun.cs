using UnityEngine;

public interface IGun
{
    void Fire(Transform _target);
    void Hold();
    void Update(float deltaTime);
}