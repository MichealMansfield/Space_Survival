using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Boundary")
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if(other.gameObject.tag == "Bullet")
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if(other.gameObject.tag == "Player")
        {
            PlayerHealth.livesLeftAmount--;
            PlayerHealth.isDead = true;
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if(other.gameObject.tag == "Shield")
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        Destroy(gameObject);
    }
}
