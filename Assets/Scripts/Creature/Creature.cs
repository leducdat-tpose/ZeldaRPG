using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    [Header("Attribute")]
    [SerializeField]
    protected float _maxHP;
    [SerializeField]
    protected float _maxMP;
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected float _rollForce;
    [SerializeField]
    protected float _jumpSpeed;
    [Header("Ability")]
    protected bool _moveAbility;
    protected bool _rollAbility;
    //Use when we want some entity can drop in to pits and death
    protected bool _isCurrentlyOnMovingPlatform;

    public void AdjustMaxHP(float hp)
    {
        this._maxHP = hp;
    }
    public void AdjustMaxMP(float mp) {  
        this._maxMP = mp;
    }

    public void AdjustSpeed(float speed)
    {
        this._speed = speed;
    }
    public void AjustRollForce(float rollForce)
    {
        this._rollForce = rollForce;
    }
    public void AjustJumpSpeed(float jumpSpeed)
    {
        this._jumpSpeed = jumpSpeed;
    }
    public void MoveAbility(bool canMove)
    {
        this._moveAbility = canMove;
    }
    public void RollAbility(bool canRoll)
    {
        this._rollAbility = canRoll;
    }
    public void isMovingOnPlatform(bool isCurrentlyOnMovingPlatform) {
        this._isCurrentlyOnMovingPlatform = isCurrentlyOnMovingPlatform;
    }
    public virtual void Moving() { }
}