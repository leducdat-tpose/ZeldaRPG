using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy: Creature
{
    private Rigidbody2D _rb;

    public override void Moving()
    {
        base.Moving();
    }
    //This just a script for every enemy, not a specific one
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        AdjustMaxHP(100);
        AdjustMaxMP(100);
        AdjustSpeed(6);
        MoveAbility(true);
        RollAbility(false);
    }
    private void Update()
    {
        
    }
}