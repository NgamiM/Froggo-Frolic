using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_ChangeAnime : MonoBehaviour
{
    public string jumpAnime = "";
    //public string downAnime = "";
    public string rightAnime = "";
    //public string leftAnime = "";

    string nowMode = "";

    // Start is called before the first frame update
    void Start()
    {
        nowMode = rightAnime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {

            nowMode = jumpAnime;


        }
       // if (Input.GetKey("down"))
      //  {
       //     nowMode = downAnime;
       // }
        //if (Input.GetKey("right"))
        //{
          //  nowMode = rightAnime;
       // }
        if (Input.GetKey("right"))
        {
         
            nowMode = rightAnime;
            
        }
    }
    void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);
    }
}
