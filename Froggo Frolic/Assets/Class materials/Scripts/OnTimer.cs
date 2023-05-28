using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnTimer : MonoBehaviour
{
    public Text timeDisplay;
    float startTime = 30;
	float time;
	public string targetObjectName;

	// Start is called before the first frame update
	void Start()
    {
        time = startTime;
        InvokeRepeating("CountDown", 0, 1);

    }

    // Update is called once per frame
    void CountDown()
    {
        time = time - 1;
    }
	public void Add()
	{
		time = time + 6;

	}
	public void Subtract()
	{
		time = time - 5;

	}
	void Update()
	{
		timeDisplay.text = time.ToString();

	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == targetObjectName)
		{
			Add();
		}
	}
}
