using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoldPerSec : MonoBehaviour {

	public Text gPS;
	private GameManager gameManager;
	public ItemManager[] items;

	void Start(){
		gameManager = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		gPS = GameObject.Find ("GPSText").GetComponent<Text>();
		StartCoroutine (AutoTick ());
	}

	void Update(){
		gPS.text = GameManager.FormatNumber(GetGoldPerSec()) + " gold/sec";
	}

	public float GetGoldPerSec(){
		float tick = 0;
		foreach (ItemManager item in items) {
			tick += item.count * item.TickValue;
		}
		return tick;
	}

	public void AutoGoldPerSec(){
		gameManager.currentGold += GetGoldPerSec() / 10;
	}

	IEnumerator AutoTick(){
		while (true) {
			AutoGoldPerSec();
			yield return new WaitForSeconds(0.10f);
		}
	}
}
