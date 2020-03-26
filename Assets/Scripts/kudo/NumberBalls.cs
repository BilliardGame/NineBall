using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberBalls : MonoBehaviour
{

	//【参考】ワガハイ式のコード↓↓

	public GameObject[] number_balls;
	float diam = 0.5f;    //球の直径
	void Start()
	{
		//数球の初期配置
		float eps = Random.Range(0, 0.01f) + 0.03f;    //数球間の隙間（ランダム）
		float pos1x = -3.8f;
		float diam2 = diam + eps;
		float deltax = diam2 * Mathf.Sqrt(3.0f) / 2.0f;
		//ball1の位置座標（数球の基準位置）
		Vector3 startpos1 = new Vector3(pos1x, 0f, 0f);
		//ball9の位置座標
		Vector3 startpos9 = new Vector3(pos1x - 2.0f * deltax, 0f, 0f);
		//ball2～8の候補位置座標
		Vector3[] startpos = new Vector3[]{
			new Vector3(pos1x-deltax,0.5f*diam2,0f),
			new Vector3(pos1x-deltax,-0.5f*diam2,0f),
			new Vector3(pos1x-2.0f*deltax,diam2,0f),
			new Vector3(pos1x-2.0f*deltax,-diam2,0f),
			new Vector3(pos1x-3.0f*deltax,0.5f*diam2,0f),
			new Vector3(pos1x-3.0f*deltax,-0.5f*diam2,0f),
			new Vector3(pos1x-4.0f*deltax,0f,0f)
		};
		//ball1とball9は位置固定
		this.number_balls[0].transform.position = startpos1;
		this.number_balls[8].transform.position = startpos9;

		//ball2～ball8はランダム：トランプシャッフルと同様の方法でランダムに
		List<int> numlist = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
		for (int i = 0; i < numlist.Count; i++)
		{
			//list[i]とlist[randomnum]を順番入れ替え
			int temp = numlist[i];
			int randomnum = Random.Range(0, numlist.Count);
			numlist[i] = numlist[randomnum];
			numlist[randomnum] = temp;
		}
		for (int i = 0; i < numlist.Count; i++)
		{
			this.number_balls[i + 1].transform.position = startpos[numlist[i]];
		}
	}
}