using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject explosionPrefab;

    [Header("Rigidbody")]
    public Rigidbody2D rb;

    [Header("Floats")]
    public float force = 8f;

    [Header("Audio")]
    public AudioSource projectileAudio;

    void Start()
    {
        Vector3 direction = new Vector3(0, -force, 0);
        rb.AddForce(direction, ForceMode2D.Impulse);
        projectileAudio.Play();
    }

    void Update()
    {
        OnLeftScreen();
    }

    private void OnLeftScreen()
    {
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!PlayerShield.shieldIsActive)
            {
                PlayerHealth.livesLeftAmount--;
                Destroy(GameObject.FindGameObjectWithTag("Player"));
                PlayerHealth.isDead = true;
                Instantiate(explosionPrefab, transform.position, transform.rotation);
            }
        }

        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Bullet"));
        }

        if(collision.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }
}
