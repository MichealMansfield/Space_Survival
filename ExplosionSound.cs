using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSound : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource explosionSound;

    void Start()
    { 
        explosionSound.Play();
    }

    void Update()
    {
        EndExplosion();
    }

    private void EndExplosion()
    {
        Destroy(gameObject, .5f);
    }
}
