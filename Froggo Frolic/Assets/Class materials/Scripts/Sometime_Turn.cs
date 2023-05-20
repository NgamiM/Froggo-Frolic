using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Turn : MonoBehaviour
{
    public float angle = 90;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0, angle / 50, 0);
    }
}
