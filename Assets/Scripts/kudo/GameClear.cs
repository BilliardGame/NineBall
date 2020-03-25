using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour {

	public GameObject ClearUI;

	void Clear()
	{
		int count = GameObject.FindGameObjectsWithTag("").Length;

		if (count == 0)
		{
			// オブジェクトをアクティブにする
			ClearUI.SetActive(true);
		}
	}
}
