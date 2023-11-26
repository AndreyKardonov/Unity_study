using UnityEngine;

[CreateAssetMenu(fileName = "RootStateConfig", menuName = "Configs/RootStateConfig")]


public class RootStateConfig : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField] private GameConfig _gameConfig;
    public GameConfig GameConfig => _gameConfig;


}
