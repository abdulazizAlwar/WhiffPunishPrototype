using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    string ActionName;

    KeyCode DashKey = KeyCode.O;
    KeyCode WeaponAttackKey = KeyCode.P;

    IEnumerator ButtonInput()
    {
        yield return StartCoroutine(WaitForKeyDown(new KeyCode[] { DashKey, WeaponAttackKey }));
        switch (ActionName)
        {
            case "Dash":
                //Dash Input
                break;
            case "WeaponAttack":
                //Weapon Attack Input
                break;

        }
    }

    IEnumerator WaitForKeyDown(KeyCode[] codes)
    {
        bool pressed = false;
        while (!pressed)
        {
            foreach (KeyCode k in codes)
            {
                if (Input.GetKey(k))
                {
                    pressed = true;
                    ButtonActionMap(k);
                    break;
                }
            }
            yield return null;
        }
    }

    string ButtonActionMap(KeyCode k)
    {
        if (k == DashKey)
        {
            ActionName = "Dash";
        }
        if (k == WeaponAttackKey)
        {
            ActionName = "WeaponAttack";
        }

        return ".";
    }
}
