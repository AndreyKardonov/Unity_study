using System;
using UnityEngine;


[Serializable]
public class IdleConfig
{
    [SerializeField] private string _idleText;
    public string IdleText => _idleText;
}
