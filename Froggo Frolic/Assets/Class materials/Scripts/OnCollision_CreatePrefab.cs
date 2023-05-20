using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_CreatePrefab : MonoBehaviour
{
    public string targetObjectName;
    public GameObject newPrefab;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetObjectName)
        {
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            Vector3 pos = collision.contacts[0].point;
            pos.z = -5;
            newGameObject.transform.position = pos;
        }
    }
}
