using System;
using UnityEngine;


[Serializable]
public class RunningConfig
{
    [SerializeField] private string _runningText;
    public string RunningText => _runningText;
}
