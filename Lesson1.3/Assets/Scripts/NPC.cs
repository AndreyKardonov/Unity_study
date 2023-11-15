using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class NPC : MonoBehaviour, INPC
{
    [SerializeField] TextMeshProUGUI _text;
    private INPC _myNPC;

    public string GetSpeech()
    {
        return _myNPC.GetSpeech();
    }


    private void SetNPC()
    {
        switch (UnityEngine.Random.Range(1, 4))
        {
            case 1:
                _myNPC = new NPC_1();
                break;
            case 2:
                _myNPC = new NPC_2();
                break;
            case 3:
                _myNPC = new NPC_3();
                break;
            default:
                _myNPC = new NPC_1();
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SetNPC();
            _text.text = GetSpeech();
        }
    }

    private void OnCollisionExit(Collision collisionInfo)
    {
        _text.text = "";
    }

}
