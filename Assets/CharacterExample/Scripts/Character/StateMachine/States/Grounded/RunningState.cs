public class RunningState : GroundedState
{
    private RunningStateConfig _config;

    public RunningState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
        => _config = character.Config.GroundStateConfig.RunningStateConfig;

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

        if (Input.Movement.Walk.triggered)
            StateSwitcher.SwitchState<WalkingState>();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();

        if (Input.Movement.Run.triggered)
            StateSwitcher.SwitchState<RacingState>();
    }
}
