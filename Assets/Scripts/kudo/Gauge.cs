using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gauge : MonoBehaviour {

	private static Vector3 sizeDelta;

	GameObject image;
	

	private void Start()
	{
		//ImageをGameObjectとして取得
		image = GameObject.Find("Image");
	}

	public void Update()
	{
		//スペース入力中はゲージを増やす
		if (Input.GetKey(KeyCode.Space))
		{
			//ImageというコンポーネントのfillAmountを取得して操作する
			image.GetComponent<Image>().fillAmount += 0.01f;
		}

			//スペースキー離したらゲージを0に戻す
			if (Input.GetKeyUp(KeyCode.Space))
			{
				image.GetComponent<Image>().fillAmount = 0f;
			}
	}

		

		

	
}
