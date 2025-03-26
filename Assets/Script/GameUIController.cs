using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public Text scoreText;
    public Text sectorText;
    public Button exitButton;
    public Button restartButton;
    public static GameUIController instance;

    private void Start()
    {
        exitButton.onClick.AddListener(GotoMenu);
        restartButton.onClick.AddListener(Restart);
    }

   
    public void GotoMenu()
    {
        GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
        SceneManager.LoadScene("Menu"); 
        
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
    }
    
    public void KucKuda() 
    {
      GameObject.Find("SoundManager").GetComponent<SoundManager>().ChickenUpSound();
    }

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
            scoreText.text = "Достаток:" + money.ToString();
        }
    }
     public void UpdateSectorText(float sector)
    {
        sectorText.text = "Землі: " + sector.ToString();
    }
}
