using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInfoScript : MonoBehaviour
{
    public GameObject InfoPanel;
    
    void Start()
    {
       Time.timeScale = 0f;

    }

    public void StartGame()
    {
      Time.timeScale = 1f;
      GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
      InfoPanel.SetActive(false);
    }  
}
