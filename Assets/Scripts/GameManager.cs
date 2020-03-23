using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	//カメラを格納する変数
	public Camera Camera;
	public Camera SubCamera;

	//キャンパスを格納
	public GameObject canvas;

	void Start()
	{
		//初めはカメラをオフにしとく
		SubCamera.enabled = false;
	}

	private void Update()
	{
		
	}

	
	//ボタンを押した時の処理
	public void PushButton ()
	{
		//サブカメラがオフだったら
		if (!SubCamera.enabled)
		{
			//サブカメラをオンにして
			SubCamera.enabled = true;

			//カメラをオフにする
			Camera.enabled = false;

			//キャンパスを映すカメラをサブカメラオブジェクトにする
			GetComponent<Canvas>().worldCamera = SubCamera;
		}
		//サブカメラがオンだったら
		else
		{
			//サブカメラをオフにして
			SubCamera.enabled = false;

			//カメラをオンにする
			Camera.enabled = true;

			//キャンパスを映すカメラをカメラオブジェクトにする
			GetComponent<Canvas>().worldCamera = Camera;
		}
		
	}
}
