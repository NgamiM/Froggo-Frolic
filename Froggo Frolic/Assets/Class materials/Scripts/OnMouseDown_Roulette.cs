using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Roulette : MonoBehaviour
{
    public float maxSpeed = 50;
    float Speed = 0;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Speed = maxSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Speed = Speed * (float)0.97;
        this.transform.Rotate(0, 0, Speed);
    }
}
