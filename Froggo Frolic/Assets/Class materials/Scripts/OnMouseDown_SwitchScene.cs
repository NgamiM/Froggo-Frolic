using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseDown_SwitchScene : MonoBehaviour
{
    public string sceneName;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
        
    }

}
