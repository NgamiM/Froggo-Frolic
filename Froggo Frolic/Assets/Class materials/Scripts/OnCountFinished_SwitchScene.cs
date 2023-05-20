using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCountFinished_SwitchScene : MonoBehaviour
{
    public int lastCount = 3;
    public string sceneName = "";

    // Update is called once per frame
    void FixedUpdate()
    {
       if(GameCounter.value == lastCount)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
