using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gauge : MonoBehaviour {

	private static Vector3 sizeDelta;

	void Shot() {
		//スペース入力中はゲージを増やす
		if (Input.GetKey(KeyCode.Space))
		{
			
		}



		//スペースキーを離したとき
		if (Input.GetKeyUp(KeyCode.Space))
		{
			//gauge.SendMessage("shot",rt.sizeDelta.z * 

			//発射したらゲージを0に戻す
			Gauge.sizeDelta = new Vector3(0.0f, 50.0f);
		}
	}
}
