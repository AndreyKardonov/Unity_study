using UnityEngine;

public class Mediator : MonoBehaviour
{
    private UI_Class _uiClass;
    private Player _player;
    public void Initialize(Player player, UI_Class uiclass)
    {
        _uiClass = uiclass;
        _player = player;
        _player.HPChangeEvent  += HPChangeProc;
        _player.LVLChangeEvent += LVLChangeProc;
        _uiClass.RSTPressed += GameRestart;
        _uiClass.HideRestartCanvas();
    }


    private void OnDisable()
    {
        _player.HPChangeEvent  -= HPChangeProc;
        _player.LVLChangeEvent -= LVLChangeProc;
        _uiClass.RSTPressed -= GameRestart;
    }
    private void HPChangeProc()
    {
        if (_player.HP<=0) 
          {
            _uiClass.ShowRestartCanvas();
            _player.StopInput();
          }
        else 
          _uiClass.SetHPText(_player.HP.ToString());   
    }

    private void LVLChangeProc() => _uiClass.SetLVLText(_player.Level.ToString());
    

    private void GameRestart()
    {
        _player.Restart();
        _uiClass.HideRestartCanvas();
        _player.StartInput();
    }

}
