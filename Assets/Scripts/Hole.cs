using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {

	private void OnCollisionEnter(Collision collision)
	{
		//1. 動いているオブジェクトが「ぶつかった」オブジェクトのタグがPlayerの時、Playerが消える
		if (collision.gameObject.tag == "Player2")
		{
			collision.gameObject.SetActive(false);
		}
		//2. 「動いている」オブジェクトのタグがPlayerの時、ぶつかったPlayer自身が消える
		if (this.gameObject.tag == "Player2")
		{
			this.gameObject.SetActive(false);
		}
	}
}
