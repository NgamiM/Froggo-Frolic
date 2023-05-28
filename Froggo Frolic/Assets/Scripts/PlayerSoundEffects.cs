using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundEffects : MonoBehaviour
{
    public AudioSource src;
    public AudioClip jumpSFX, runSFX;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            src.clip = jumpSFX;
            src.Play();
        }
       // if (Input.GetKey("down"))
      //  {
       //     nowMode = downAnime;
       // }
        //if (Input.GetKey("right"))
        //{
          //  nowMode = rightAnime;
       // }
        if (Input.GetKey("right"))
        {
            src.clip = runSFX;
            src.Play();
        }
    }
}

