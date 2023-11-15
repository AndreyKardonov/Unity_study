using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour, INPC
{


    [SerializeField] TextMeshProUGUI _text;


    private List<string> PlayerPhrases;

    private Rigidbody rb;
    public float speed = 2f;
    private Vector3 moveVector;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


 

    void FixedUpdate()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = 0; 
        moveVector.z = 0;// Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);

       


    }

    public string GetSpeech()
    {
        return PlayerPhrases[UnityEngine.Random.Range(1, PlayerPhrases.Count)-1];
    }
 


    private void Start()
    {
        PlayerPhrases = new List<string>();
        LoadDictionary();
    }

    public void LoadDictionary()
    {
        PlayerPhrases.Add("Привет! Чем торгуешь?");
        PlayerPhrases.Add("Есть что на продажу?");
        PlayerPhrases.Add("Мне нужна твоя одежда.");
        PlayerPhrases.Add("Меняю деньги на еду.");
         

    }

    private void OnTriggerEnter(Collider other)
    {
        _text.text = GetSpeech();
    }

}
