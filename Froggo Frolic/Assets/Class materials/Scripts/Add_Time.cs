using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add_Time : MonoBehaviour
{

	public Text timeDisplay;

	float startTime = 30;
	float time;
	public string targetObjectName;

	private void Start()
	{
		time = startTime;
		InvokeRepeating("CountDown", 0, 1);
	}

	void CountDown()
	{
		time = time - 1;
	}

	public void Add()
	{
		time = time + 5;
	}

	public void Subtract()
	{
		time = time - 5;
	}

	// Update is called once per frame
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
