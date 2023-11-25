using UnityEngine;


[CreateAssetMenu(fileName = "RootStateConfig", menuName = "Configs/RootStateConfig")]


public class RootStateConfig : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField] private IdleConfig _idleConfig;
    public IdleConfig IdleConfig => _idleConfig;
    [SerializeField] private WorkingConfig _workingConfig;
    public WorkingConfig WorkingConfig => _workingConfig;


    [SerializeField] private RunningConfig _runningConfig;
    public RunningConfig RunningConfig => _runningConfig;


    [SerializeField] private SinginigConfig _singingConfig;
    public SinginigConfig SingingConfig => _singingConfig;


}
