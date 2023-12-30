using System;
using UnityEngine;

[Serializable]
public class RacingStateConfig
{
    [SerializeField, Range(11, 15)] private float _speed;

    public float Speed => _speed;
}
