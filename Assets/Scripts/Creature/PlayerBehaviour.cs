using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : HighHuman
{
    protected float _inputVertical;
    protected float _inputHorizontal;
    private void Update()
    {
        UpdateInput();
    }
    private void UpdateInput()
    {
        _inputVertical = Input.GetAxis("Vertical");
        _inputHorizontal = Input.GetAxis("Horizontal");
    }
}
