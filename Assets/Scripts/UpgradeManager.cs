using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class UpgradeManager : MonoBehaviour {

	
	private GameManager gameManager;
	private ChestTapScript chestTap;
	private MultiplierScript multi;
	public Text iteminfo;
	public Text itemCost;
	public Text goldPerClick;
	public float cost;
	public float endCost;
	public int count;
	public int gPC;
	public float gpcDisplay;
	public string ItemName;
	private float baseCost;
	public Color Standard;
	public Color Affordable;
	public Slider SliderColor;
	private int multiply;
	AudioSource levelUp;

	void Start(){
		chestTap = GameObject.Find ("Chest").GetComponent<ChestTapScript> ();
		gameManager = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		multi = GameObject.Find ("UpgradeMultiplier").GetComponent<MultiplierScript> ();
		levelUp = this.GetComponent<AudioSource> ();
		gpcDisplay = gPC / (float)1000;
		baseCost = (cost * multi.multiplier);
		SliderColor = GetComponentInChildren<Slider> ();

		if (PlayerPrefs.HasKey (ItemName)) {
				count = PlayerPrefs.GetInt (ItemName);
				cost = PlayerPrefs.GetFloat(ItemName + " Cost");
		} else {
			
		}
	}
	void Update(){
		PlayerPrefs.SetInt (ItemName, count);
		PlayerPrefs.SetFloat(ItemName + " Cost", cost);

		//Debug.Log (gpcDisplay);

		iteminfo.text = ItemName + " (" + count + ")";

		//calculates cost w/ multiplier
		endCost = cost * multi.multiplier;

		multiply = multi.multiplier;
		multiply = multiply * (int)cost;
		if (multi.multiplier == 1) {
			itemCost.text = "1X      " + GameManager.FormatNumber (multiply);
		}
		if (multi.multiplier == 10) {
			itemCost.text = "10X     " + GameManager.FormatNumber (multiply);
		}
		if (multi.multiplier == 100) {
			itemCost.text = "100X    " + GameManager.FormatNumber (multiply);
		}
		goldPerClick.text = "Fat%: " + gpcDisplay;

		/*if (Click.Gold >= Cost) {
			GetComponent<Image> ().color = Affordable;
		} else {
			GetComponent<Image> ().color = Standard;
		}*/
		if (SliderColor.value >= 100) {
			GetComponent<Image> ().color = Affordable;
		} else {
			GetComponent<Image> ().color = Standard;
		}
		SliderColor.value = gameManager.currentGold / (cost * multi.multiplier) * 100;
	}

	public void OnMouseDown(){
		if (gameManager.currentGold >= endCost) {
			gameManager.currentGold -= endCost;
			count += multi.multiplier;
			chestTap.goldPerClick += multi.multiplier;
			cost = (Mathf.Round (baseCost * Mathf.Pow(1.15f, count)) * multi.multiplier);
			levelUp.Play();
		}
	}
}
