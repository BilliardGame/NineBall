using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

	public Text timerText;
	public float totalTime;
	float seconds;
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
			seconds += Time.deltaTime;
			if (seconds >= 59)
			{
				minute++;
				seconds = seconds - 59;
			}
			//seconds = (int)totalTime;
					timerText.text = minute.ToString("00") + ":" + seconds.ToString("00");
		}

		
		if (Input.GetKey(KeyCode.Space))
		{
			x = 1;
		}

		//oldSeconds = seconds;
	}


}