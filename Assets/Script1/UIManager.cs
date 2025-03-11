using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private Text scoreText; 
    public float money = 500; 

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

    public void UpdateMoneyText(float money)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score:" + money.ToString();
        }
    }
}
