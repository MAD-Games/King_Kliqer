using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	
	private GameManager gameManager;
	private ChestTapScript chestTap;
	public Text iteminfo;
	public Text itemCost;
	public Text goldPerClick;
	public float cost;
	public int count;
	public int gPC;
	public string ItemName;
	private float baseCost;
	public Color Standard;
	public Color Affordable;
	public Slider SliderColor;
	AudioSource levelUp;

	void Start(){
		chestTap = GameObject.Find ("Chest").GetComponent<ChestTapScript> ();
		gameManager = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		levelUp = this.GetComponent<AudioSource> ();

		baseCost = cost;
		SliderColor = GetComponentInChildren<Slider> ();
	}
	void Update(){
		iteminfo.text = ItemName + " (" + count + ")";
		itemCost.text = GameManager.FormatNumber (cost);
		goldPerClick.text = "Fat%: " + gPC;

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
		SliderColor.value = gameManager.currentGold / cost * 100;
	}

	public void PurchasedUpgrade(){
		if (gameManager.currentGold >= cost) {
			gameManager.currentGold -= cost;
			count += 1;
			chestTap.goldPerClick += gPC;
			cost = Mathf.Round (baseCost * Mathf.Pow(1.15f, count));
			levelUp.Play();
		}
	}
}
