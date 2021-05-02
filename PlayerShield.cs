using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShield : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject shield;

    [Header("Bools")]
    private bool shieldOn = false;
    public static bool shieldIsActive = false;

    [Header("Floats")]
    public float shieldTime = 5;

    void Start()
    {
        shieldOn = shieldIsActive;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && TurnShieldOn.canUseShield == true)
        {
            shieldOn = true;
            shieldIsActive = true;
            UseShield();
        }
    }

    private void UseShield()
    {
        if (shieldOn)
        {
            shield.SetActive(true);
            StartCoroutine(ShieldInUse());
        }
    }

    IEnumerator ShieldInUse()
    {
        yield return new WaitForSeconds(shieldTime);
        shield.SetActive(false);
        shieldOn = false;
        shieldIsActive = false;
    }
}
