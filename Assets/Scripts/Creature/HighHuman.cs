using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighHuman : Creature
{
    private void Start()
    {
        AdjustSpeed(7.0f);
        JumpAbility(true);
        AjustJumpForce(5.0f);
        AjustJumpSpeed(5.0f);
    }
    public void Run()
    {
        
    }
}
