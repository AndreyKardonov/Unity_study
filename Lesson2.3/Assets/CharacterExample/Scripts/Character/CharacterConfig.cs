using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private SpeedRunningStateConfig _speedRunningStateConfig;
    [SerializeField] private SlowRunningStateConfig _slowRunningStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;

    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public SpeedRunningStateConfig SpeedRunningStateConfig => _speedRunningStateConfig;
    public SlowRunningStateConfig SlowRunningStateConfig => _slowRunningStateConfig;
}
