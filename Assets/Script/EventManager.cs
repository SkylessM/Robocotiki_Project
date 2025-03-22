using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public GameObject[] eventObjects; 
    public float eventInterval; 
    public float eventStart;

    private void Start()
    {
       
        foreach (GameObject eventObj in eventObjects)
        {
            eventObj.SetActive(false);
            
        }
        
         InvokeRepeating("TriggerRandomEvent", eventStart, eventInterval);
    }

    
   private void TriggerRandomEvent()
    {
        foreach (GameObject eventObj in eventObjects)
        {
            eventObj.SetActive(false);
        }

        int randomIndex = Random.Range(0, eventObjects.Length);
        eventObjects[randomIndex].SetActive(true);
        Time.timeScale = 0f;
    }
}
