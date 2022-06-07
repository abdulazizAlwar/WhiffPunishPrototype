using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : FighterBase
{
    protected bool BackDashInput;
    protected bool ForwardDashInput;

    protected override void MovementController()
    {
        HorizontalMovement = Input.GetAxis("Horizontal");
        MovementAction();
    }

    protected override void DashController()
    {
        BackDashInput = Input.GetKeyDown(KeyCode.O) && HorizontalMovement > 0;
        ForwardDashInput = Input.GetKeyDown(KeyCode.O) && HorizontalMovement <= 0;

        if (BackDashInput)
        {
            BackDashAction();
        }
        if (ForwardDashInput)
        {
            ForwardDashAction();
        }
    }
}
