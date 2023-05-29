using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnMouseDown_StopMusic : MonoBehaviour
{
    AudioSource backgroundMusic;
   
   void Start()
   {
       backgroundMusic = Camera.main.gameObject.GetComponent<AudioSource>();
   }
     void OnMouseDown()
    {
        if(backgroundMusic.isPlaying)
        {
            backgroundMusic.Pause();
        }
        else
        {
            backgroundMusic.Play();
        }
        
    }
}
