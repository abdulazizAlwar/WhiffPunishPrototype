using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class PlayerClass : FighterBase
{
    public Color PlayerColor;

    protected bool BackDashInput;
    protected bool ForwardDashInput;
    protected bool WeaponAttackInput;

    private void Start()
    {
        SetColor();
    }

    void SetColor()
    {
        PlayerColor = GameManager.Instance.PlayerColor;
        Material material = transform.Find("Rye").Find("ma").Find("MA Body 2").GetComponent<Renderer>().material;
        material.color = PlayerColor;
    }

    // POLYMORPHISM
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

    protected override void WeaponAttackController()
    {
        WeaponAttackInput = Input.GetKeyDown(KeyCode.P);

        if (WeaponAttackInput)
        {
            StartCoroutine(WeaponSwingHoldRoutine());
        }
    }

}
