using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class WalkingState : GroundedState
{
    private WalkingStateConfig _config;

    public WalkingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
    {
        _config = character.Config.GroundStateConfig.WalkingStateConfig;
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();

        if(Input.Movement.Walk.triggered)
            StateSwitcher.SwitchState<MovementState>();
    }
}
