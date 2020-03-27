using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public GameObject ball;
	public float shotSpeed;
	
	float dgr = 0;
	int power = 0;
	

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update() {
		/*
		if (Input.GetMouseButton(0))
		{
			Rigidbody test = ball.GetComponent<Rigidbody>();
			test.AddForce(transform.forward * shotSpeed);
		}
		*/

		
		
		Vector3 pos = transform.position;

		//Xキーを押している間CueStick表示
		if (Input.GetKey(KeyCode.X))
		{

		}


		//スペースバーを押した処理
		if (Input.GetKeyDown(KeyCode.Space))
		{
			power = 0;
		}
		//スペースバーを押している間の処理
		if (Input.GetKey(KeyCode.Space))
		{
			power = power + 5;
		}
		//スペースバーを離した処理。ボールを打つ
		if (Input.GetKeyUp(KeyCode.Space))
		{
			Vector3 v = Camera.main.transform.position;
			v -= pos;
			v *= power * -1;
			v.y = 0;
			transform.GetComponent<Rigidbody>().AddForce(v);
		}

		//MAXゲージを500にする
		if (power >= 500)
		{
			power = 500;
		}

	
		//左矢印キーの処理。視点を回す
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Camera.main.transform.RotateAround(pos, new Vector3(0, 10, 0), -0.3f);
			dgr += 0.3f;
		}
		//右矢印キーの処理。視点を回す
		if (Input.GetKey(KeyCode.RightArrow))
		{
			Camera.main.transform.RotateAround(pos, new Vector3(0, 10, 0), 0.3f);
			dgr += -0.3f;
		}

		//カメラの新たな位置の計算と設定
		float d = (2 * Mathf.PI) * (dgr / 360);
		float x = Mathf.Sin(d);
		float y = Mathf.Cos(d);
		x *= 10f;
		y *= 10f;
		pos.x += x;
		pos.y += 10f;
		pos.z -= y;
		Camera.main.transform.position = pos;
	
	}
	

}
