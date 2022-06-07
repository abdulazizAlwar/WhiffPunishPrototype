using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
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

    // POLYMORPHISM
    protected abstract void MovementController();
    protected abstract void DashController();
    protected abstract void WeaponAttackController();

    // ABSTRACTION
    public void MovementAction()
    {
        transform.Translate(Vector3.right * HorizontalMovement * moveSpeed / 60);
    }

    // ABSTRACTION
    protected void ForwardDashAction()
    {
        transform.Translate(Vector3.left * dashSpeed / 60);
    }

    protected void BackDashAction()
    {
        transform.Translate(Vector3.right * dashSpeed / 60);
    }

    protected IEnumerator WeaponSwingHoldRoutine()
    {
        weapon.transform.localPosition = new Vector3(-1.5f, 0, 0.5f);
        yield return new WaitForSeconds(WeaponSwingHoldDuration);
        weapon.transform.localPosition = new Vector3(-1f, 0, 0.5f);
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
