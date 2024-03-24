using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallSlideState : PlayerState
{
    public PlayerWallSlideState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.ChangeState(player.wallJump);
            return;
        }

        if (yInput < 0)
            playerRb.velocity = new Vector2(0, playerRb.velocity.y);
        else
            playerRb.velocity = new Vector2(0, playerRb.velocity.y * 0.7f);

        if (xInput != 0 && player.facingDir != xInput || player.IsGroundedDetected())
                stateMachine.ChangeState(player.idleState);
    }
}
