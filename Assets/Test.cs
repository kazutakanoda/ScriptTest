using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; //MP

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	// 魔法攻撃用の関数
	public void Magic() { 
		int mpCount = 5;

		//もしMPが５以上余っていたら魔法攻撃を行う
		if(this.mp >= 5){
			//MPを５消費する
			this.mp = this.mp - mpCount;
			Debug.Log( "魔法攻撃をした。残りMPは" + this.mp );
			//もしMPが５以下なら下記のメッセージを表示させる
		}else{
			Debug.Log( "MPが足りないため魔法が使えない。" );
		}
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] points = {10, 20, 30, 40, 50};

		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < points.Length; i++) {
				// 配列の要素を表示する
				Debug.Log (points [i]);
		}

		// 配列の各要素の値を逆順に表示するように繰り返す
		for (int j = points.Length - 1; j >= 0; j--) {
			// 配列の要素を表示する
			Debug.Log (points [j]);
		}

		//以下、応用問題
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);

		// 魔法攻撃を11回繰り返す
		for (int i = 0; i < 11; i++) {
			// 配列の要素を表示する
			lastboss.Magic();
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
	