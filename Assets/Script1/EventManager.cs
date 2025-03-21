using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public GameObject[] eventObjects; 
    public float eventInterval; 

    private void Start()
    {
       
        foreach (GameObject eventObj in eventObjects)
        {
            eventObj.SetActive(false);
            
        }
        //Time.timeScale = 0f;
        StartCoroutine(TriggerRandomEvent());
    }

    IEnumerator TriggerRandomEvent()
    {
        while (true)
        {
            yield return new WaitForSeconds(eventInterval); 
           
            foreach (GameObject eventObj in eventObjects)
            {
                eventObj.SetActive(false);
            }


            int randomIndex = Random.Range(0, eventObjects.Length);
            eventObjects[randomIndex].SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
