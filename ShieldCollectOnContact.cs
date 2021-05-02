using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollectOnContact : MonoBehaviour
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
            if(TurnShieldOn.canUseShield == false)
            {
                TurnShieldOn.canUseShield = true;
            }
        }

        Destroy(gameObject);
    }

}
