using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	
	private GameManager gameManager;
	private ChestTapScript chestTap;
	public Text iteminfo;
	public float cost;
	public int count;
	public int fatGain;
	public string ItemName;
	private float baseCost;
	public Color Standard;
	public Color Affordable;
	public Slider SliderColor;
	public AudioSource levelUp;

	void Start(){
		chestTap = GameObject.Find ("Chest").GetComponent<ChestTapScript> ();
		gameManager = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		levelUp = GameObject.Find ("Main Camera").GetComponent<AudioSource> ();
		baseCost = cost;
		SliderColor = GetComponentInChildren<Slider> ();
	}
	void Update(){
		iteminfo.text = ItemName + "\nCost: " + GameManager.FormatNumber(cost) + "\nConsumed: (" + count + ")" + "\n+Fat%: " + fatGain;
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
			chestTap.goldPerClick += fatGain;
			cost = Mathf.Round (baseCost * Mathf.Pow(1.15f, count));
			levelUp.Play();

		}
	}
}
