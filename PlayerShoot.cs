using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject projectilePrefab;
    public GameObject specialProjectilePrefab;

    [Header("Floats")]
    public float delayTime = 0.25f;

    [Header("Bools")]
    public bool canShoot = true;

    [Header("Ints")]
    public static int specialAttacksRemaining = 99; //CHANGE THIS BEFORE RELEASE

    void Update()
    {
        if(StartingSceneScript.gameStarted && canShoot && Input.GetMouseButton(0))
        {
            canShoot = false;
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            StartCoroutine(FireDelay());
        }

        if (StartingSceneScript.gameStarted && canShoot && specialAttacksRemaining > 0 && Input.GetMouseButton(1))
        {
            canShoot = false;
            Instantiate(specialProjectilePrefab, transform.position, transform.rotation);
            specialAttacksRemaining--;
            StartCoroutine(FireDelay());
        }
    }

    IEnumerator FireDelay()
    {
        yield return new WaitForSeconds(delayTime);
        canShoot = true;
    }
}
