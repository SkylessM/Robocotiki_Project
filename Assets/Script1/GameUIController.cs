using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public Text scoreText;
    public Button exitButton;
    public Button restartButton;

    private void Start()
    {
        exitButton.onClick.AddListener(GotoMenu);
        restartButton.onClick.AddListener(Restart);
    }

    public void UpdateScore(float money)
    {
        scoreText.text = "Достаток: " + money.ToString();
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
