using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSector : MonoBehaviour
{
    public float incomePerSecond = 10f; 

    void Start()
    {
        InvokeRepeating("GenerateIncome", 1f, 1f); 
    }

    void GenerateIncome()
    {
        GameController.instance.AddMoney(incomePerSecond); 
    }
}