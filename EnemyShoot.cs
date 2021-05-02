using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject projectilePrefab;

    [Header("Floats")]
    public float delayTime = 4f;

    [Header("Bools")]
    public bool canShoot = true;

    void Update()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            StartCoroutine(FireDelay());
        }
    }

    IEnumerator FireDelay()
    {
        yield return new WaitForSeconds(delayTime);
        canShoot = true;
    }
}
