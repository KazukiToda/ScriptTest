using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	public void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		this.hp -= damage;
	}

	public void Magic() { 
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

}
public class Test : MonoBehaviour {

	void Start () {
		//課題
		int[] array = { 12, 900, 5, 66, 999 };

		Debug.Log (array [0]);
		Debug.Log (array [1]);
		Debug.Log (array [2]);
		Debug.Log (array [3]);
		Debug.Log (array [4]);

		for(int i = 4;i >= 0;i--){
			Debug.Log (array [i]);
		}

		//発展課題
		Boss lastboss = new Boss ();

		lastboss.Attack();
		lastboss.Defence(3);

		for (int j = 0; j < 11; j++) {
			lastboss.Magic ();
		}
	}

	// Update is called once per frame
	void Update () {

	}
}