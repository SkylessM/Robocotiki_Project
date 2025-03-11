using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    public GameObject losePanel; 
    public GameController gameController; 

    private void Start()
    {
        //Time.timeScale = 1f;
    }
    
    private void Update()
    {
        if (gameController.money <= 0) 
        {
            ShowLosePanel();
        }
    }

    void ShowLosePanel()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Menu"); 
    }
}
