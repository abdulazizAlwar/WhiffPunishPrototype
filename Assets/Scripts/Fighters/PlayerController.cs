using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public float horizontalInput;

    // // Start is called before the first frame update

    // // Update is called once per frame
    // void Update()
    // {
    //     BoundryRange();

    //     Movement();
    //     Dash();
    //     SwingWeapon();
    // }

    // void SwingWeapon()
    // {
    //     if (Input.GetKeyDown(KeyCode.P))
    //     {
    //     StartCoroutine(WeaponSwingHoldRoutine());
    //     }
    // }

    // // Keep player inside stage bounds
    // void BoundryRange()
    // {
    //     if (transform.position.x < -xRange)
    //     {
    //         BoundryStop(-xRange);
    //     }
    //     if (transform.position.x > xRange)
    //     {
    //         BoundryStop(xRange);
    //     }

    // }
    // void BoundryStop(float xRange)
    // {
    //     transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    // }

    // public IEnumerator WeaponSwingHoldRoutine()
    // {
    //     weapon.transform.localPosition = new Vector3(-1.5f, 0, 0.5f);
    //     yield return new WaitForSeconds(WeaponSwingHoldDuration);
    //     weapon.transform.localPosition = new Vector3(-1f, 0, 0.5f);
    // }
}
