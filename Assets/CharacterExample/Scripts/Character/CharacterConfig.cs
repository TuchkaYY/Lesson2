using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharaterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private AirbornStateConfig _airbornStateConfig;
    [SerializeField] private GroundStateConfig _groundStateConfig;

    public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
   
    public GroundStateConfig GroundStateConfig => _groundStateConfig;
}
