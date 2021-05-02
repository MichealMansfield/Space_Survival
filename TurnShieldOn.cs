using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnShieldOn : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject shield;

    [Header("Bool")]
    public static bool canUseShield = true;

    void Start()
    {
        shield.SetActive(true);
    }

    void Update()
    {
        if (canUseShield)
        {
            shield.SetActive(true);
        }

        if (canUseShield == true && PlayerShield.shieldIsActive)
        {
            shield.SetActive(false);
            canUseShield = false;
        }
    }
}
