using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{
    public GameObject victoryPanel; 
    public GameController gameController; 
    public float VictoryScore;

    private void Start()
    {
       //Time.timeScale = 1f;
    }
    
    private void Update()
    {
        if (gameController.money >= VictoryScore) 
        {
            ShowVictoryPanel();
            
        }
    }

    void ShowVictoryPanel()
    {
        victoryPanel.SetActive(true);
        Time.timeScale = 0f; 
    }
    public void RestartGame()
    {
        Time.timeScale = 1f; 
        GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f; 
        GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
        SceneManager.LoadScene("Menu"); 
    }
}
