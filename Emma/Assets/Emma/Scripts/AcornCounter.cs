﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AcornCounter : MonoBehaviour
{
    //Set Variables
    public int amount;
    public Text textComponent;
    public GameObject rootCanvas;
    private static GameObject instance;
    //public bool ableToEnterLeafPile;

    public InventoryManager im;

    // bool for total clicks event in "ClicksToFinishGame" script
    public bool acornCounterLevelDoneBool;

    void Start()
    {
        im = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();

        //ableToEnterLeafPile = true;
        acornCounterLevelDoneBool = false;

        // Keep the Canvas in between scenes
        DontDestroyOnLoad(rootCanvas);

        // Don't spawn a 2nd canvas if the first one is still there when loading a new scene
        if (instance == null)
        {
            instance = rootCanvas;
        }
        else
        {
            Destroy(rootCanvas);
        }
    }

    // Counts upwards when an acorn is collected
    void Update()
    {
        amount = im.acornOnHand;
        textComponent.text = "Acorns: " + amount;
    }

    // So can load a scene if correct amount of acorns
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
