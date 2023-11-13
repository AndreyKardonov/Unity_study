using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGun : MonoBehaviour
{
    [SerializeField] Player _player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Set Gun -1");
            _player.SetGun(new Gun_1());
        }

    }
}
