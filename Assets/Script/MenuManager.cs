using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void GoToStart()
   {
    SceneManager.LoadScene(1);
     //SceneManager.LoadScene("Menu"); 
   }
   public void Exit()
   {
      Application.Quit();
   }
}
