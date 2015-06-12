using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

	public Text itemInfo;
	private GameManager gameManager;
	public Sprite[] icons;
	public float Cost;
	public int TickValue;
	public int count;
	public string itemName;
	private float baseCost;
	public Color Standard;
	public Color Affordable;
	private Slider ColorChange;


	void Start(){
		gameManager = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		baseCost = Cost;
		ColorChange = GetComponentInChildren<Slider> ();
	}

	void Update(){
		itemInfo.text = itemName + "\nCost: " + Cost + "\nUpgrades: (" + count + ")" + "\nIncome: " + TickValue + " gold/s";
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
			GameObject.Find(itemName + "Icon").GetComponent<SpriteRenderer>().sprite = icons[0];
		} else if ((count >= 10) & (count < 25)) {
			GameObject.Find(itemName + "Icon").GetComponent<SpriteRenderer>().sprite = icons[1];
		} else if ((count >= 25) & (count < 50)) {
			GameObject.Find(itemName + "Icon").GetComponent<SpriteRenderer>().sprite = icons[2];
		}
		ColorChange.value = gameManager.currentGold / Cost * 100;
	}

	public void PurchasedItem(){
		if (gameManager.currentGold >= Cost) {
			gameManager.currentGold -= Cost;
			count += 1;
			Cost = Mathf.Round(baseCost * Mathf.Pow (1.15f, count));
		}
	}
}
