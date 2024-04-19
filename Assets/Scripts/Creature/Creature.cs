using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected bool _moveAbility;
    protected float _speed;
    protected bool _jumpAbility;
    protected float _jumpForce;
    protected float _jumpSpeed;
    //Use when we want some entity can drop in to pits and death
    protected bool _isCurrentlyOnMovingPlatform;
    protected void AdjustSpeed(float speed)
    {
        this._speed = speed;
    }
    protected void AjustJumpForce(float jumpForce)
    {
        this._jumpForce = jumpForce;
    }
    protected void AjustJumpSpeed(float jumpSpeed)
    {
        this._jumpSpeed = jumpSpeed;
    }
    protected void JumpAbility(bool canJump)
    {
        this._jumpAbility = canJump;
    }
    protected void isMovingOnPlatform(bool isCurrentlyOnMovingPlatform)
    {
        this._isCurrentlyOnMovingPlatform = isCurrentlyOnMovingPlatform;
    }
}
