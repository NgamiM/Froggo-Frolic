using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forever_ShowCount : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = GameCounter.value.ToString();
    }
}
