using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_PlayCollectSFX : MonoBehaviour
{
    public string targetObjectName;
    [SerializeField] private AudioSource collectSFX;
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.name == targetObjectName)
        {
            collectSFX.Play();
        }
    }
}
