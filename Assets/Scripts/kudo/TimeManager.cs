using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

	public Text timerText;
	public float totalTime;
	int seconds;

	// Use this for initialization
	void Start()
	{
		
	}


	// 時間経過計測
	void Update()
	{
		totalTime += Time.deltaTime;
		seconds = (int)totalTime;
		
		timerText.text = seconds.ToString();
	}


}
