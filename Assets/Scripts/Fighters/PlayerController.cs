using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : FighterBase
{
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        weapon = transform.Find("Weapon").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        BoundryRange();

        Movement();
        Dash();
        SwingWeapon();
    }

    void Movement()
    {
        //Move Left & Right
        transform.Translate(Vector3.right * horizontalInput * moveSpeed / 60);
    }

    void Dash()
    {
        // Backdash
        if (Input.GetKeyDown(KeyCode.O) && horizontalInput > 0)
        {
            transform.Translate(Vector3.right * dashSpeed / 60);
        }
        // Forward Dash
        else if (Input.GetKeyDown(KeyCode.O))
        {
            transform.Translate(Vector3.left * dashSpeed / 60);

        }
    }

    void SwingWeapon()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
        StartCoroutine(WeaponSwingHoldRoutine());
        }
    }

    // Keep player inside stage bounds
    void BoundryRange()
    {
        if (transform.position.x < -xRange)
        {
            BoundryStop(-xRange);
        }
        if (transform.position.x > xRange)
        {
            BoundryStop(xRange);
        }

    }
    void BoundryStop(float xRange)
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    public IEnumerator WeaponSwingHoldRoutine()
    {
        weapon.transform.localPosition = new Vector3(-1.5f, 0, 0.5f);
        yield return new WaitForSeconds(WeaponSwingHoldDuration);
        weapon.transform.localPosition = new Vector3(-1f, 0, 0.5f);
    }
}
