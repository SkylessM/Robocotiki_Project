using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class Sector : MonoBehaviour
{
    public Button buyButton; 
    public GameObject sectorObjects; 
    public float sectorPrice = 100f; 
    public float incomePerSecond = 10f; 
     public float _sector = 1f;
    private bool isUnlocked = false; 
    [SerializeField] private Tilemap tilemapT;
    [SerializeField] private Tilemap tilemapB;

    void Start()
    {
        buyButton.gameObject.SetActive(true); 
        sectorObjects.SetActive(false); 
        tilemapT.color = Color.gray;
        tilemapB.color = Color.gray;
    }


    public void BuySector()
    {
        if (GameController.instance.money >= sectorPrice)
        {
            GameController.instance.AddMoney(-sectorPrice);
            GameController.instance.AddSector(_sector); 
            sectorObjects.SetActive(true); 
            GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
            buyButton.gameObject.SetActive(false); 
            isUnlocked = true; 
            tilemapT.color = Color.white;
            tilemapB.color = Color.white;
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
