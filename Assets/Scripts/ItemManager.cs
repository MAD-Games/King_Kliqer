using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

	public Text itemInfo;
	public Text itemCost;
	public Text goldIncome;
	private GameManager gameManager;
	private CurrentHat currentHat;
	public Sprite[] icons;
	public float Cost;
	public int tickValue;
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
		if (PlayerPrefs.HasKey (itemName)) {
			count = PlayerPrefs.GetInt ("hat" + itemName);
			Cost = PlayerPrefs.GetFloat("hat" + itemName + " Cost");
		} 
	}

	void Update(){
		PlayerPrefs.SetInt ("hat" + itemName, count);
		PlayerPrefs.SetFloat("hat" + itemName + " Cost", Cost);

		//itemInfo.text = itemName + "\nCost: " + Cost + "\nUpgrades: (" + count + ")" + "\nIncome: " + tickValue + " gold/s";
		itemInfo.text = itemName + " (" + count + ")";
		itemCost.text = GameManager.FormatNumber (Cost);
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
