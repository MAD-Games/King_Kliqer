using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Click : MonoBehaviour {

	public Text GPC;
	public Text GoldDisplay;
	public float Gold = 0.00f;
	public int GoldPerClick = 0;

	void Update (){
		GoldDisplay.text = "Gold: " + Gold.ToString("F0");
		GPC.text = GoldPerClick + " gold/click";
	}

	public void Clicked(){
		Gold += GoldPerClick;
	}

}
