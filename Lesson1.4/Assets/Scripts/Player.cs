using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    private int _myCondition = 0;  // Тип игры - 0 это цветные шары, 1 это все шары
    private int _startColor = -1;
    [SerializeField] private GameObject _startCanvas;
    [SerializeField] private GameObject _badCanvas;
    [SerializeField] private GameObject _goodCanvas;
    [SerializeField] TextMeshProUGUI _res;

    [SerializeField] private int _countOfColors = 5;
    [SerializeField] private int _countOfSpheres=5;
    private int _count = 0;

    [SerializeField] private GameObject _spherePrefab;
    private GameObject newSphere;
    private MyColors clr;
    private int[] colorGoals;


    public void StartGame(int cnd)
    {
        _myCondition = cnd;
        _startColor = -1;
        _count = 0;
        _startCanvas.SetActive(false);
        colorGoals=new int[_countOfColors];
        for (int i = 0;i<_countOfColors;i++) colorGoals[i]=0;   

        clr = new MyColors();
        clr.LoadMyColors(_countOfColors);

        for (int i = 0; i < _countOfSpheres; i++)
        {
            Vector3 newPosition = new Vector3(UnityEngine.Random.Range(-8f, 8f), 0, UnityEngine.Random.Range(-4f, 4f));
            newSphere = GameObject.Instantiate(_spherePrefab, newPosition, Quaternion.Euler(0, 0, 0));

            int tp = UnityEngine.Random.Range(0, _countOfColors);
            newSphere.GetComponent<SphereClass>().SetType(tp,clr.GetColor(tp));
            colorGoals[tp]++;


         }
        SphereClass.chpokEvent += SetChpok;
    }

    private void SetChpok(int tp)
    {
        if (_startColor == -1) _startColor = tp;
        _count++;

        if (_myCondition == 0)
        {
            if (_startColor != tp)
            {
                BadFinal();
                return;
            }
            if (colorGoals[_startColor] == _count) GoodFinal();
            _res.text = _count.ToString() + " / " + colorGoals[_startColor].ToString();
        }
        else
        {
            if (_countOfSpheres == _count) GoodFinal();
            _res.text = _count.ToString() + " / " + _countOfSpheres.ToString();

        }
    }

    private void GoodFinal()
    {
        _goodCanvas.SetActive(true);
    }
    private void BadFinal()
    {
        _badCanvas.SetActive(true);

    }


}
