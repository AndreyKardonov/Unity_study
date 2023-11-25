using System;
using UnityEngine;

[Serializable]
public class SpeedRunningStateConfig
{
    [SerializeField, Range(0, 20)] private float _speed;

    public float RunningSpeed => _speed;
}
