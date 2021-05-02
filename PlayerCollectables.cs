using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "CoinCollectable")
        {
            ScoreScript.scoreAmount += 500;
            Destroy(GameObject.FindGameObjectWithTag("CoinCollectable"));
        }

        if (other.gameObject.tag == "ShieldCollectable")
        {
            if (!PlayerShield.shieldIsActive)
            {
                PlayerShield.shieldIsActive = true;
                Destroy(GameObject.FindGameObjectWithTag("ShieldCollectable"));
            }
        }

        if (other.gameObject.tag == "HeartCollectable")
        {
            if (PlayerHealth.livesLeftAmount < 3)
            {
                PlayerHealth.livesLeftAmount++;
                Destroy(GameObject.FindGameObjectWithTag("HeartCollectable"));
            }
        }
    }
}
