using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{

    private int _myCondition = 0;
    [SerializeField] private GameObject _startCanvas;
    [SerializeField] private int _countOfSpheres=5;
    [SerializeField] TextMeshProUGUI _res;

    [SerializeField] private GameObject _spherePrefab;
    private GameObject newSphere;
    private int _count = 0;

    public void StartGame(int cnd)
    {
        _myCondition = cnd;
        _count = 0;
        _startCanvas.SetActive(false);

        for (int i = 0; i < _countOfSpheres; i++)
        {
            Vector3 newPosition = new Vector3(UnityEngine.Random.Range(-8, 8), 0, UnityEngine.Random.Range(-4, 4));
            newSphere = GameObject.Instantiate(_spherePrefab, newPosition, Quaternion.Euler(0, 0, 0));

            int tp = UnityEngine.Random.Range(0, 3);
            newSphere.GetComponent<SphereClass>().SetType(tp);


         }
        SphereClass.chpokEvent += SetChpok;
    }

    private void SetChpok(int tp)
    {
        _count++;
        _res.text = _count.ToString();  
    }

}
