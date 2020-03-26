using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gauge : MonoBehaviour {

	private static Vector3 sizeDelta;

	GameObject image;
	float x = 0.001f;

	private void Start()
	{
		//ImageをGameObjectとして取得
		image = GameObject.Find("Image");
	}

	public void HPDown(float current, int max)
	{
		//ImageというコンポーネントのfillAmountを取得して操作する
		image.GetComponent<Image>().fillAmount = current / max;
	}

		void Shot() {
		

		if (x == 0.001f)
		{
			x++;
		}

		//スペース入力中はゲージを増やす
		if (Input.GetKey(KeyCode.Space))
		{
			x = 0.001f;
		}


		//スペースキーを離したらゲージを0に戻す
		/*if (Input.GetKeyUp(KeyCode.Space))
		{
			x = 0;
		}*/
	}
}
