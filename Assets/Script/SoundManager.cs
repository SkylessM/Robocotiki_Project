using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip ButtonSound;
    public void ButtonUpSound()
    {
      StartCoroutine(SoundPlay(ButtonSound, ButtonSound.length));
    }
     IEnumerator SoundPlay(AudioClip audioClip, float time)
      {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = audioClip;
        audio.pitch = Random.Range(0.9f, 1.1f);
        audio.volume = 0.2f;
        audio.Play();
        yield return new WaitForSeconds(time);
        
        Destroy(audio);
      }
}
