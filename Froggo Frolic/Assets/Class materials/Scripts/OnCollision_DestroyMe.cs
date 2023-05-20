using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_DestroyMe : MonoBehaviour
{
    public string targetObjectName;
        // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetObjectName)
        {
            Destroy(this.gameObject);
        }
    }
}
