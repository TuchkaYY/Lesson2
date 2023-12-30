using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingState : GroundedState
{
    private RacingStateConfig _config;

    public RacingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
    {
        _config = character.Config.GroundStateConfig.RacingStateConfig;
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

        if (Input.Movement.Run.triggered)
            StateSwitcher.SwitchState<MovementState>();
    }
}
