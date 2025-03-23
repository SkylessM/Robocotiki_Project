using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
  
   public void GoToStart()
   {
    SceneManager.LoadScene(1);
     GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
     //SceneManager.LoadScene("Menu"); 
   }
   public void Exit()
   {
      GameObject.Find("SoundManager").GetComponent<SoundManager>().ButtonUpSound();
      Application.Quit();
   }
}
