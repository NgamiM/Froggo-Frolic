using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveGravity : MonoBehaviour
{
        public string jumpAnime = "";
    //public string downAnime = "";
    public string rightAnime = "";
    //public string leftAnime = "";

    string nowMode = "";


    public float speed = 3;
    public float jumppower = 8;

    float vx = 0;
    bool leftFlag = false;
    bool pushFlag = false;
    bool jumpFlag = false;
    bool groundFlag = false;
    Rigidbody2D rbody;

    [SerializeField] private AudioSource jumpSFX;
    [SerializeField] private AudioSource stepSFX;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        nowMode = rightAnime;
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            nowMode = rightAnime;
            stepSFX.Play();
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            nowMode = rightAnime.;
            stepSFX.Play();
            vx = -speed;
            leftFlag = true;
        }
        if (Input.GetKey("space") && groundFlag)
        {
            jumpSFX.Play();
            nowMode = jumpAnime;
            if (pushFlag == false)
            {
                jumpFlag = true;
                pushFlag = true;
            }
        }
        else
        {
            pushFlag = false;
        }
    }
    void FixedUpdate()
    {
        
        rbody.velocity = new Vector2(vx, rbody.velocity.y);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        this.GetComponent<Animator>().Play(nowMode);
        if (jumpFlag)
        {
            jumpFlag = false;
            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        groundFlag = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        groundFlag = false;

    }
}
