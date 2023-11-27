using System;
using UnityEngine;


[Serializable]
public class GameConfig
{
    [SerializeField] private int _level;
    [SerializeField] private int _HP;
    [SerializeField] private int _speed;

    public int Level => _level;
    public int HP => _HP;
    public int Speed => _speed;

}
