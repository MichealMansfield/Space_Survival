using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExplosion : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject explosionPrefab;

    private void Update()
    {
        if (PlayerHealth.isDead)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
    }
}
