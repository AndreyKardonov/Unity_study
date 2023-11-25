using System;
using UnityEngine;


[Serializable]
public class SinginigConfig
{
    [SerializeField] private string _singingText;
    public string SingingText => _singingText;
}
