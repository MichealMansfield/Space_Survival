using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectOnContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

        if(other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }

        if(other.gameObject.tag == "Player")
        {
            if(PlayerHealth.livesLeftAmount < 3)
            {
                PlayerHealth.livesLeftAmount++;
            }
        }

        Destroy(gameObject);
    }

}
