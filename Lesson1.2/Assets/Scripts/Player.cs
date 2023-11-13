using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    private IGun _myGun;
    [SerializeField] Transform _target;

  

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Fire!");
            Fire(_target);
        }
    }
    
    public void SetGun(IGun igun)
    {
        _myGun?.Hold();
        _myGun = igun;

    }
    public void Fire(Transform target)
    {
        _myGun.Fire(target);
    }
}
