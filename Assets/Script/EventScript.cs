using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventScript : MonoBehaviour
{
    public Button eventButton; 
    public GameObject eventPanel; 
    public float costToSubtract; 

    private GameController gameController; 

    void Start()
    {
        gameController = FindObjectOfType<GameController>(); 
        eventButton.onClick.AddListener(HandleEvent);
    }

    void HandleEvent()
    {
        if (gameController != null)
        {
            gameController.SpendMoney(-costToSubtract);
        }
        eventPanel.SetActive(false); 
        //Time.timeScale = 1f;
        if (Time.timeScale == 0f)
        {
           Time.timeScale = 1f;
        }
    }
}

