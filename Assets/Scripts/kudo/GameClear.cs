using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour {

	public GameObject ClearUI;

	void Start()
	{
		ClearUI.SetActive(false);
	}

	private void Update()
	{
		
	}


	/*void Clear()
	{
		int count = GameObject.FindGameObjectsWithTag("").Length;

		if (count == 0)
		{
			// オブジェクトをアクティブにする
			ClearUI.SetActive(true);
		}
	}*/
}
