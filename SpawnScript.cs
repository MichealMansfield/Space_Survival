using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [Header("Ship Prefabs")]
    public GameObject shipOne;
    public GameObject shipTwo;
    public GameObject shipThree;
    public GameObject shipFour;
    public GameObject shipFive;

    [Header("Panels")]
    public GameObject characterSelectionPanel;
    public GameObject startingScenePanel;
    public GameObject gameplayPanel;

    [Header("Audio")]
    public AudioSource shipSelection;

    [Header("Bools")]
    public static bool startingSceneActive = false;
    public static bool characterSelectionPanelActive = true;
    public static bool shipOneIsActive = false;
    public static bool shipTwoIsActive = false;
    public static bool shipThreeIsActive = false;
    public static bool shipFourIsActive = false;
    public static bool shipFiveIsActive = false;
    public static bool activeShip = false;

    private void Start()
    {
        characterSelectionPanel.SetActive(true);
        startingScenePanel.SetActive(false);
        gameplayPanel.SetActive(false);
    }

    void Update()
    {
        activeShip = PlayerRespawn.currentShip;

        if(shipOneIsActive == activeShip)
        {
            shipOneIsActive = true;
        }   

        if(shipTwoIsActive == activeShip)
        {
            shipTwoIsActive = true;
        }

        if (shipThreeIsActive == activeShip)
        {
            shipThreeIsActive = true;
        }

        if (shipFourIsActive == activeShip)
        {
            shipFourIsActive = true;
        }

        if (shipFiveIsActive == activeShip)
        {
            shipFiveIsActive = true;
        }
    }

    public void OnShipOneClick()
    {
        characterSelectionPanel.SetActive(false);
        startingScenePanel.SetActive(true);
        startingSceneActive = true;
        Instantiate(shipOne, new Vector3(0, -8, 0), Quaternion.identity);
        gameplayPanel.SetActive(true);
        shipSelection.Stop();
        characterSelectionPanelActive = false;
        shipOneIsActive = true;
        activeShip = shipOneIsActive;
    }

    public void OnShipTwoClick()
    {
        characterSelectionPanel.SetActive(false);
        startingScenePanel.SetActive(true);
        startingSceneActive = true;
        Instantiate(shipTwo, new Vector3(0, -8, 0), Quaternion.identity);
        gameplayPanel.SetActive(true);
        shipSelection.Stop();
        characterSelectionPanelActive = false;
        shipTwoIsActive = true;
        activeShip = shipTwoIsActive;
    }

    public void OnShipThreeClick()
    {
        characterSelectionPanel.SetActive(false);
        startingScenePanel.SetActive(true);
        startingSceneActive = true;
        Instantiate(shipThree, new Vector3(0, -8, 0), Quaternion.identity);
        gameplayPanel.SetActive(true);
        shipSelection.Stop();
        characterSelectionPanelActive = false;
        shipThreeIsActive = true;
        activeShip = shipThreeIsActive;
    }

    public void OnShipFourClick()
    {
        characterSelectionPanel.SetActive(false);
        startingScenePanel.SetActive(true);
        startingSceneActive = true;
        Instantiate(shipFour, new Vector3(0, -8, 0), Quaternion.identity);
        gameplayPanel.SetActive(true);
        shipSelection.Stop();
        characterSelectionPanelActive = false;
        shipFourIsActive = true;
        activeShip = shipFourIsActive;
    }

    public void OnShipFiveClick()
    {
        characterSelectionPanel.SetActive(false);
        startingScenePanel.SetActive(true);
        startingSceneActive = true;
        Instantiate(shipFive, new Vector3(0, -8, 0), Quaternion.identity);
        gameplayPanel.SetActive(true);
        shipSelection.Stop();
        characterSelectionPanelActive = false;
        shipFiveIsActive = true;
        activeShip = shipFiveIsActive;
    }
}
