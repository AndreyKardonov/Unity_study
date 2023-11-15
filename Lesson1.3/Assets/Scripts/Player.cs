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
   public float speed = 2f;

    private List<string> PlayerPhrases;
    private Rigidbody rb;
    private Vector3 moveVector;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = 0; 
        moveVector.z = 0;
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }

    public string GetSpeech()
    {
        return PlayerPhrases[UnityEngine.Random.Range(0, PlayerPhrases.Count)];
    }

    private void Start()
    {
        PlayerPhrases = new List<string>();
        LoadDictionary();
    }

    private void LoadDictionary()
    {
        PlayerPhrases.Add("Привет! Чем торгуешь?");
        PlayerPhrases.Add("Есть что на продажу?");
        PlayerPhrases.Add("Меняю деньги на еду.");         
    }

   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "NPC")
            _text.text = GetSpeech();
    }
    private void OnCollisionExit(Collision collisionInfo)
    {
        _text.text = "";
    }
}
