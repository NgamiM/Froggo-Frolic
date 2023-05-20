using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Rotate : MonoBehaviour
{
    public float angle = 360;
    float rotateAngle = 0;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        rotateAngle = angle;
    }

    // Update is called once per frame
    void OnMouseUp()
    {
        rotateAngle = 0;
    }
    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, rotateAngle / 50);
    }
}
