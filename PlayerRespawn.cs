using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [Header("Ship Prefabs")]
    public GameObject shipOne;
    public GameObject shipTwo;
    public GameObject shipThree;
    public GameObject shipFour;
    public GameObject shipFive;

    [Header("Float")]
    public float respawnTime = 2.0f;

    public static bool currentShip = true;

    void Update()
    {
        if (PlayerHealth.isDead)
        {
            StartCoroutine(SpawnNewShip());
        }
    }

    IEnumerator SpawnNewShip()
    {
        yield return new WaitForSeconds(respawnTime);
        if (SpawnScript.shipOneIsActive && PlayerHealth.isDead)
        {
            PlayerHealth.isDead = false;
            SpawnScript.shipOneIsActive = false;
            Instantiate(shipOne, new Vector3(0, -8, 0), Quaternion.identity);
            SpawnScript.shipOneIsActive = currentShip;
        }

        if (SpawnScript.shipTwoIsActive && PlayerHealth.isDead)
        {
            PlayerHealth.isDead = false;
            SpawnScript.shipTwoIsActive = false;
            Instantiate(shipTwo, new Vector3(0, -8, 0), Quaternion.identity);
            SpawnScript.shipTwoIsActive = currentShip;
        }

        if (SpawnScript.shipThreeIsActive && PlayerHealth.isDead)
        {
            PlayerHealth.isDead = false;
            SpawnScript.shipThreeIsActive = false;
            Instantiate(shipThree, new Vector3(0, -8, 0), Quaternion.identity);
            SpawnScript.shipThreeIsActive = currentShip;
        }

        if (SpawnScript.shipFourIsActive && PlayerHealth.isDead)
        {
            PlayerHealth.isDead = false;
            SpawnScript.shipFourIsActive = false;
            Instantiate(shipFour, new Vector3(0, -8, 0), Quaternion.identity);
            SpawnScript.shipFourIsActive = currentShip;
        }

        if (SpawnScript.shipFiveIsActive && PlayerHealth.isDead)
        {
            PlayerHealth.isDead = false;
            SpawnScript.shipFiveIsActive = false;
            Instantiate(shipFive, new Vector3(0, -8, 0), Quaternion.identity);
            SpawnScript.shipFiveIsActive = currentShip;
        }
    }
}
