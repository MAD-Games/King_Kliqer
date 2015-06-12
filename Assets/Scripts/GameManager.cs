using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public static GameManager manager;

	//public GameObject panel1;
	//public GameObject panel2;
	private ItemManager itemManager;
	private UpgradeManager upgradeManager;
	private bool panelHats = false;
	private bool panelFood = false;
	
	// Hat counters
	public int barrelHat;
	public int hotdogHat;
	
	// Food counters
	public int breadFood;
	public int meatFood;
	
	// Player Stats
	public int fatPercent = 0;
	public float currentGold = 0.00f;
	// public int playerProgression = 0;

	public GameObject panelInfo1;
	public GameObject panelInfo2;

	public int upgradeCount;
	public int clickTotal;

	
	// Use this for initialization
	void Awake () {
		if (manager == null) {
			DontDestroyOnLoad (gameObject);
			manager = this;
		} else if (manager != this) {
			Destroy (gameObject);
		}


	}
	
	// Update is called once per frame
	void Update () {
		if (panelInfo2.gameObject.activeInHierarchy == true) {
			barrelHat = GameObject.Find ("Barrel").GetComponent<ItemManager> ().count;
			hotdogHat = GameObject.Find ("Hotdog").GetComponent<ItemManager> ().count;
		} else if (panelInfo1.gameObject.activeInHierarchy == true) {
			breadFood = GameObject.Find ("Bread").GetComponent<UpgradeManager> ().count;
			meatFood = GameObject.Find ("Meat").GetComponent<UpgradeManager> ().count;
		}
		upgradeCount = barrelHat + hotdogHat + breadFood + meatFood;
	}
	public static string FormatNumber(float flt) {
		int num = (int)Mathf.Ceil (flt);
		if (num >= 1000000)
			return FormatNumber(num / 100000) + "M";
		if (num >= 100000)
			return (num / 1000000D).ToString("0.#") + "M";
		if (num >= 100000)
			return (FormatNumber(num / 1000) + "K");
		if (num >= 10000) {
			return ((num / 1000D).ToString("0.#") + "K");
		}
		return num.ToString("#,0");
	}
	public void activatePanelFood()
	{
		if (panelFood == false && panelHats == true) 
		{

			panelInfo2.gameObject.SetActive(false);
			panelInfo1.gameObject.SetActive(true);
			panelFood = true;
			
		} 
		else if (panelFood == true) 
		{
			panelFood = false;
			panelInfo1.gameObject.SetActive(false);
			
		}
		else if (panelFood == false) 
		{
			panelFood = true;
			panelInfo1.gameObject.SetActive(true);
			
		}
	}
	public void activatePanelHats()
	{
		if (panelFood == true && panelHats == false) 
		{
			panelInfo1.gameObject.SetActive(false);
			panelInfo2.gameObject.SetActive(true);
			panelHats = true;
		} 
		else if (panelHats == true) 
		{
			panelHats = false;
			panelInfo2.gameObject.SetActive(false);
		}
		else if (panelHats == false) 
		{
			panelHats = true;
			panelInfo2.gameObject.SetActive(true);
		}
		
	}

}