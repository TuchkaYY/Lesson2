using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GroundStateConfig
{
    [SerializeField] private RacingStateConfig _racingStateConfig;
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private WalkingStateConfig _walkingStateConfig;

    public RacingStateConfig RacingStateConfig => _racingStateConfig;
    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
}
