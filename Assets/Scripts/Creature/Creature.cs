using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    [Header("Attribute")]
    protected float _maxHP;
    protected float _maxMP;
    protected float _speed;
    protected float _rollForce;
    protected float _jumpSpeed;
    [Header("Ability")]
    protected bool _moveAbility;
    protected bool _rollAbility;
    //Use when we want some entity can drop in to pits and death
    protected bool _isCurrentlyOnMovingPlatform;

    protected void AdjustMaxHP(float hp)
    {
        this._maxHP = hp;
    }
    protected void AdjustMaxMP(float mp) {  
        this._maxMP = mp;
    }

    protected void AdjustSpeed(float speed)
    {
        this._speed = speed;
    }
    protected void AjustRollForce(float rollForce)
    {
        this._rollForce = rollForce;
    }
    protected void AjustJumpSpeed(float jumpSpeed)
    {
        this._jumpSpeed = jumpSpeed;
    }
    protected void MoveAbility(bool canMove)
    {
        this._moveAbility = canMove;
    }
    protected void RollAbility(bool canRoll)
    {
        this._rollAbility = canRoll;
    }
    protected void isMovingOnPlatform(bool isCurrentlyOnMovingPlatform)
    {
        this._isCurrentlyOnMovingPlatform = isCurrentlyOnMovingPlatform;
    }
    protected virtual void Moving() { }
}
