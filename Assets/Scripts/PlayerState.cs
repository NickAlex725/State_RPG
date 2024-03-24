using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;

    protected Rigidbody2D playerRb;

    protected float xInput;
    protected float yInput;
    private string animBoolName;

    protected float stateTimer;

    public PlayerState(Player player, PlayerStateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        player.anim.SetBool(animBoolName, true);
        playerRb = player.rb;
    }

    public virtual void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        player.anim.SetFloat("yVelocity", playerRb.velocity.y);

        stateTimer -= Time.deltaTime;

        //Debug.Log(_stateMahince._currentState);
    }

    public virtual void Exit()
    {
        player.anim.SetBool(animBoolName, false);
    }
}
