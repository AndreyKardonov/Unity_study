using System;
using UnityEngine;


[Serializable]
public class WorkingConfig
{
    [SerializeField] private string _workText;
    public string WorkText => _workText;
}
