using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip ButtonSound;
    public AudioClip ChickenClick;
   // public AudioClip VictorySound;
   // public AudioClip LoseSound;

    public void ButtonUpSound()
    {
      StartCoroutine(SoundPlay(ButtonSound, ButtonSound.length));
    }
    public void ChickenUpSound()
    {
      StartCoroutine(SoundPlay(ChickenClick, ChickenClick.length));
    }

   /* public void StartVictorySound()
    {
      StartCoroutine(SoundPlay(VictorySound, VictorySound.length));
    }
     public void StartLoseSound()
    {
      StartCoroutine(SoundPlay(LoseSound, LoseSound.length));
    }*/

     IEnumerator SoundPlay(AudioClip audioClip, float time)
      {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = audioClip;
        audio.pitch = Random.Range(0.9f, 1.1f);
        audio.volume = 0.4f;
        audio.loop = false;
        audio.Play();
        yield return new WaitForSeconds(time);
        
        Destroy(audio);
      }
}
