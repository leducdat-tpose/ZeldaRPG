using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected float _speed;
    protected float _jumpForce;
    protected float _jumpSpeed;
    protected bool _jumpAbility;
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
}
