using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Class : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button _restart;
    [SerializeField] Canvas _hudCanvas;
    [SerializeField] GameObject _restartCanvas;
    public TextMeshProUGUI _hpText;
    public TextMeshProUGUI _lvlText;

    public void SetHPText(string hpText) => _hpText.text = hpText;
    public void SetLVLText(string lvlText) => _lvlText.text = lvlText;

    public void Show() => gameObject.SetActive(true);
    public void Hide() => gameObject.SetActive(false);

    public void ShowRestartCanvas() => _restartCanvas.SetActive(true);
    public void HideRestartCanvas() => _restartCanvas.SetActive(false);


    private void OnEnable()
    {
        _restart.onClick.AddListener(Restart);

    }

    private void OnDisable()
    {
        _restart.onClick.RemoveListener(Restart);
    }

    private void Restart()
    {
      //restart level
    }
}
