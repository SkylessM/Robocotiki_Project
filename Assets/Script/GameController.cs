using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public float money = 10f; 
    public float sector = 0f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddMoney(float amount)
    {
        money += amount;
        GameUIController.instance.UpdateMoneyText(money);
    }

    public void SpendMoney(float amount)
    {
        money -= amount;
        GameUIController.instance.UpdateMoneyText(money);
    }
    public void AddSector(float amount)
    {
        sector += amount;
        GameUIController.instance.UpdateSectorText(sector);
    }
}