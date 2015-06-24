using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {
	
	public static GameManager manager;

	//public GameObject panel1;
	//public GameObject panel2;
	private ItemManager itemManager;
	private UpgradeManager upgradeManager;
	Image food;
	Image hat;
	public Sprite FoodOn;
	public Sprite FoodOff;
	public Sprite HatOn;
	public Sprite HatOff;

	private Sprite UIImageHat;
	private bool panelHats = false;
	private bool panelFood = false;
	
	// Hat counters
	public int barrelHat;
	public int mimiHat;
	public int jackHat;
	
	// Food counters
	public int boneFood;
	public int cheeseFood;
	public int grapeFood;

	//public Sprite image;
	
	// Player Stats
	public int fatPercent = 0;
	public float currentGold = 0.00f;
	// public int playerProgression = 0;

	public GameObject panelInfo1;
	public GameObject panelInfo2;
	public GameObject foodButton;
	public GameObject hatButton;

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
		food = foodButton.GetComponent<Image> ();
		hat = hatButton.GetComponent<Image> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (panelInfo2.gameObject.activeInHierarchy == true) {
			barrelHat = GameObject.Find ("Barrel").GetComponent<ItemManager> ().count;
			mimiHat = GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count;
			jackHat = GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count;
		} else if (panelInfo1.gameObject.activeInHierarchy == true) {
			cheeseFood = GameObject.Find ("Cheese").GetComponent<UpgradeManager> ().count;
			boneFood = GameObject.Find ("Bone").GetComponent<UpgradeManager> ().count;
			grapeFood = GameObject.Find ("Grapes").GetComponent<UpgradeManager> ().count;
		}
		upgradeCount = barrelHat + mimiHat + jackHat + cheeseFood + grapeFood + boneFood;
		//Debug.Log (1.0f / Time.deltaTime);
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
			food.sprite = FoodOn;
			hat.sprite = HatOff;
			panelInfo2.gameObject.SetActive(false);
			panelInfo1.gameObject.SetActive(true);
			panelFood = true;
			
		} 
		else if (panelFood == true) 
		{
			food.sprite = FoodOff;
			panelFood = false;
			panelInfo1.gameObject.SetActive(false);
			
		}
		else if (panelFood == false) 
		{
			food.sprite = FoodOn;
			panelFood = true;
			panelInfo1.gameObject.SetActive(true);
			
		}
	}
	public void activatePanelHats()
	{
		if (panelFood == true && panelHats == false) 
		{
			hat.sprite = HatOn;
			food.sprite = FoodOff;
			panelInfo1.gameObject.SetActive(false);
			panelInfo2.gameObject.SetActive(true);
			panelHats = true;
		} 
		else if (panelHats == true) 
		{
			hat.sprite = HatOff;
			panelHats = false;
			panelInfo2.gameObject.SetActive(false);
		}
		else if (panelHats == false) 
		{
			hat.sprite = HatOn;
			panelHats = true;
			panelInfo2.gameObject.SetActive(true);
		}
		
	}

}