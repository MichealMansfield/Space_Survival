using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    [Header("Rigidbody")]
    public Rigidbody2D rb;

    [Header("Floats")]
    public float force = 8f;

    [Header("Audio")]
    public AudioSource projectileAudio;

    void Start()
    {
        if(StartingSceneScript.gameStarted)
        {
            Vector3 direction = new Vector3(0, force, 0);
            rb.AddForce(direction, ForceMode2D.Impulse);
            projectileAudio.Play();
        }
    }

    void Update()
    {
        OnLeftScreen();
    }

    private void OnLeftScreen()
    {
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            ScoreScript.scoreAmount += 100;
        }
    }
}
