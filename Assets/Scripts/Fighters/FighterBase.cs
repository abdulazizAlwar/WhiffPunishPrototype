using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FighterBase : MonoBehaviour
{
    protected GameObject weapon;

    public float moveSpeed = 5.0f;
    public float dashSpeed = 50.0f;
    public float WeaponSwingHoldDuration = 0.5f;
    protected float xRange = 7.5f;

}
