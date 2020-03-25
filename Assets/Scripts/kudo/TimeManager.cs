using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

	public Text timerText;
	public float totalTime;
	int seconds;
	int minute;
	int oldSeconds = 0;
	int x = 0;

	// Use this for initialization
	void Start()
	{
	
	}


	// 時間経過計測
	void Update()
	{
		

		if (x == 1)
		{
			totalTime += Time.deltaTime;
			if (seconds >= 60f)
			{
				minute++;
				seconds = seconds - 60;
			}
			//seconds = (int)totalTime;
					timerText.text = minute.ToString("00") + ":" + seconds.ToString("00");
		}

		
		if (Input.GetKey(KeyCode.Space))
		{
			x = 1;
		}

		oldSeconds = seconds;
	}


}