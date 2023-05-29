using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timers : MonoBehaviour
{
	
	public float Timeleft;
	public bool TimerOn = false;
	public Text TimerTxt;
	public float lastCount;
	public string sceneName = "";

	// Start is called before the first frame update
	void Start()
	{
		
		TimerOn = true;

	}

	// Update is called once per frame
	void Update()
	{
		if (TimerOn)
		{
			if (Timeleft > 0)
			{
				Timeleft -= Time.deltaTime;
				updateTimer(Timeleft);

			}
			else
			{
				
		
				TimerOn = false;
			}
			if (Timeleft < 0)
			{
				SceneManager.LoadScene(sceneName);
			}
		}
		
	}
	

	void updateTimer(float currentTime)
	{
		currentTime += 1;
		float minutes = Mathf.FloorToInt(currentTime / 60);
		float seconds = Mathf.FloorToInt(currentTime % 60);
		TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
	}
	// Update is called once per frame
	



}
