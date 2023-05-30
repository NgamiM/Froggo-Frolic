using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_CountAndHide : MonoBehaviour
{
    public string targetObjectName;
    public int addValue = 1;
    //[SerializeField] private AudioSource collectSFX;
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.name == targetObjectName)
        {
            //collectSFX.Play();
            GameCounter.value = GameCounter.value + addValue;
            this.gameObject.SetActive(false);
        }
    }

   
}
