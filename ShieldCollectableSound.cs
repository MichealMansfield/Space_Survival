using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollectableSound : MonoBehaviour
{
    [Header("Audio Source")]
    public AudioSource shieldSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ShieldCollectable")
        {
            shieldSound.Play();
        }
    }
}
