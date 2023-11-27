using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Class : MonoBehaviour
{
   
    [SerializeField] private Button _restartButton;
    [SerializeField] GameObject _restartCanvas;
    public TextMeshProUGUI _hpText;
    public TextMeshProUGUI _lvlText;
    public event Action RSTPressed;

    public void SetHPText(string hpText) => _hpText.text = hpText;
    public void SetLVLText(string lvlText) => _lvlText.text = lvlText;
    public void ShowRestartCanvas() => _restartCanvas.SetActive(true);
    public void HideRestartCanvas() => _restartCanvas.SetActive(false);


    private void Restart() => RSTPressed?.Invoke();
    private void OnEnable() => _restartButton.onClick.AddListener(Restart);
    private void OnDisable() => _restartButton.onClick.RemoveListener(Restart);
    
}
