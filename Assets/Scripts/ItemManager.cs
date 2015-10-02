using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour {

	public Text itemInfo;
	public Text itemCost;
	public Text goldIncome;
	private MultiplierScript multi;
	private GameManager gameManager;
	private CurrentHat currentHat;
	public Sprite[] icons;
	public float Cost;
	public float endCost;
	public int tickValue;
	public int count;
	public string itemName;
	private float baseCost;
	public Color Standard;
	public Color Affordable;
	private Slider ColorChange;
	public int hatNumber;
	public int whichHat;
	private int multiply;



	void Start(){
		gameManager = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		baseCost = Cost;
		ColorChange = GetComponentInChildren<Slider> ();
		if (PlayerPrefs.HasKey (itemName)) {
			count = PlayerPrefs.GetInt (itemName);
			Cost = PlayerPrefs.GetFloat(itemName + "Cost");
		} 
		multi = GameObject.Find ("UpgradeMultiplier").GetComponent<MultiplierScript> ();

	

	}

	void Update(){
		PlayerPrefs.SetInt (itemName, count);
		PlayerPrefs.SetFloat(itemName + "Cost", Cost);

		//itemInfo.text = itemName + "\nCost: " + Cost + "\nUpgrades: (" + count + ")" + "\nIncome: " + tickValue + " gold/s";
		itemInfo.text = itemName + " (" + count + ")";

		//calculates cost w/ multiplier
		endCost = Cost * multi.multiplier;

		multiply = multi.multiplier;
		multiply = multiply * (int)Cost;
		if (multi.multiplier == 1) {
			itemCost.text = "1X      " + GameManager.FormatNumber (multiply);
		}
		if (multi.multiplier == 10) {
			itemCost.text = "10X      " + GameManager.FormatNumber (multiply);
		}
		if (multi.multiplier == 100) {
			itemCost.text = "100X      " + GameManager.FormatNumber (multiply);
		}
	//itemCost.text = GameManager.FormatNumber (Cost);
		goldIncome.text = "Income: " + tickValue;
		/*if (Click.Gold >= Cost) {
			GetComponent<Image> ().color = Affordable;
		} else {
			GetComponent<Image> ().color = Standard;
		}*/
		if (ColorChange.value >= 100) {
			GetComponent<Image> ().color = Affordable;
		} else {
			GetComponent<Image> ().color = Standard;
		}

		if (count < 10) {
			hatNumber = 0;
			if(whichHat == 1){
			GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat1>().hats[0];
			}
			if(whichHat == 2){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat2>().hats[0];
			}
			if(whichHat == 3){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat3>().hats[0];
			}
			if(whichHat == 4){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat4>().hats[0];
			}
			if(whichHat == 5){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat5>().hats[0];
			}

				
				//this.gameObject.GetComponent<Image>().sprite = Resources.Load ("newImage") as Image;
			

		} else if ((count >= 10) & (count < 25)) {
			if(whichHat == 1){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat1>().hats[1];
			}
			if(whichHat == 2){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat2>().hats[1];
			}
			if(whichHat == 3){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat3>().hats[1];
			}
			if(whichHat == 4){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat4>().hats[1];
			}
			if(whichHat == 5){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat5>().hats[1];
			}
			//GameObject.Find(itemName + "Icon").GetComponent<SpriteRenderer>().sprite = icons[1];
			hatNumber = 1;
		} else if ((count >= 25)) {
			if(whichHat == 1){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat1>().hats[2];
			}
			if(whichHat == 2){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat2>().hats[2];
			}
			if(whichHat == 3){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat3>().hats[2];
			}
			if(whichHat == 4){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat4>().hats[2];
			}
			if(whichHat == 5){
				GameObject.Find(itemName + "Icon").GetComponent<Image>().sprite = GameObject.Find(itemName + "Icon").GetComponent<WearHat5>().hats[2];
			}
			//GameObject.Find(itemName + "Icon").GetComponent<SpriteRenderer>().sprite = icons[2];
			hatNumber = 2;
		}
		ColorChange.value = gameManager.currentGold / (Cost * multi.multiplier) * 100;
	}

	public void OnMouseDown(){
		if (gameManager.currentGold >= endCost) {
			gameManager.currentGold -= endCost;
			count += multi.multiplier;
			Cost = (Mathf.Round(baseCost * Mathf.Pow (1.15f, count)) * multi.multiplier);
		}
	}


	}



