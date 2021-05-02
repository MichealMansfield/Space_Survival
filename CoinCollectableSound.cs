using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectableSound : MonoBehaviour
{
    [Header("Audio Source")]
    public AudioSource coinSound;

    [Header("Audio Clip")]
    public AudioClip coinClip;
    public AudioClip shieldClip;
    public AudioClip healthClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "CoinCollectable")
        {
            coinSound.PlayOneShot(coinClip);
        }

        if (collision.gameObject.tag == "HeartCollectable")
        {
            coinSound.PlayOneShot(healthClip);
        }

        if (collision.gameObject.tag == "shieldCollectable")
        {
            coinSound.PlayOneShot(shieldClip);
        }
    }
}
