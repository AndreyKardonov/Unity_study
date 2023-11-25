using System;
using UnityEngine;

[Serializable]
public class SlowRunningStateConfig
{
    [SerializeField, Range(0, 20)] private float _speed;

    public float SlowSpeed => _speed;
}
