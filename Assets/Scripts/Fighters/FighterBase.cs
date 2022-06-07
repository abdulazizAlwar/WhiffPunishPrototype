using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FighterBase : MonoBehaviour
{
    protected GameObject weapon;
    protected float HorizontalMovement;

    public float moveSpeed = 5.0f;
    public float dashSpeed = 50.0f;
    public float WeaponSwingHoldDuration = 0.5f;
    protected float xRange = 7.5f;

    void Awake()
    {
        weapon = transform.Find("Weapon").gameObject;
    }

    private void Update()
    {
        MovementController();
        DashController();

        BoundryRangeReset();
    }

    //Override below controllers based on class:
    //Player: Player input
    //Opponent: Opponent AI
    protected abstract void MovementController();
    protected abstract void DashController();

    public void MovementAction()
    {
        transform.Translate(Vector3.right * HorizontalMovement * moveSpeed / 60);
    }

    protected void ForwardDashAction()
    {
        transform.Translate(Vector3.left * dashSpeed / 60);
    }

    protected void BackDashAction()
    {
        transform.Translate(Vector3.right * dashSpeed / 60);
    }

    void BoundryRangeReset()
    {
        if (transform.position.x < -xRange)
        {
            BoundryStop(-xRange);
        }
        if (transform.position.x > xRange)
        {
            BoundryStop(xRange);
        }

        void BoundryStop(float xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
