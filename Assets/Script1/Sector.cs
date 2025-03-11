using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sector : MonoBehaviour
{
    public Button buyButton; 
    public GameObject sectorObjects; 
    public float sectorPrice = 100f; 
    public float incomePerSecond = 10f; 

    private bool isUnlocked = false; 

    void Start()
    {
        buyButton.gameObject.SetActive(true); 
        sectorObjects.SetActive(false); 
    }

    public void BuySector()
    {
        if (GameController.instance.money >= sectorPrice)
        {
            GameController.instance.AddMoney(-sectorPrice); 
            sectorObjects.SetActive(true); 
            buyButton.gameObject.SetActive(false); 
            InvokeRepeating("GenerateIncome", 1f, 1f); 
        }
    }

    void GenerateIncome()
    {
        if (isUnlocked)
        {
            GameController.instance.AddMoney(incomePerSecond); 
        }
    }
}
