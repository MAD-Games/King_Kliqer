using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {
	
	public static GameManager manager;

	//public GameObject panel1;
	//public GameObject panel2;
	private ItemManager itemManager;
	private UpgradeManager upgradeManager;

	//update stats menu
	public TextMesh clickText;
	public TextMesh totalUpgrades;
	public TextMesh totalGold;

	Image food;
	Image hat;
	public Sprite FoodOn;
	public Sprite FoodOff;
	public Sprite HatOn;
	public Sprite HatOff;

	private Sprite UIImageHat;
	private bool panelHats = false;
	private bool panelFood = false;
	private bool gameStart;
	
	// Hat counters
	public int barrelHat;
	public int mimiHat;
	public int jackHat;
	public int birdhouse;
	public int hookah;
	
	// Food counters
	public int boneFood;
	public int cheeseFood;
	public int grapeFood;
	public int snailFood;
	public int boneMeatFood;
	public int donutFood;

	//public Sprite image;
	
	// Player Stats
	public int fatPercent = 0;
	public float currentGold = 0.00f;
	public float totalGoldEarned = 0.00f;
	// public int playerProgression = 0;

	public GameObject panelInfo1;
	public GameObject panelInfo2;
	public GameObject foodButton;
	public GameObject hatButton;

	public int upgradeCount;
	public int clickTotal = 0;

	
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

		if (PlayerPrefs.HasKey ("gold")) {
			currentGold = PlayerPrefs.GetFloat ("gold");
			clickTotal = PlayerPrefs.GetInt ("clicks");
			totalGoldEarned = PlayerPrefs.GetFloat("totalGold");


		} else {
			currentGold = 0.00f;
		}
	}


	// Update is called once per frame
	void Update () {
		if (gameStart == false) {
			gameStart = true;
			barrelHat = GameObject.Find ("Barrel").GetComponent<ItemManager> ().count;
			mimiHat = GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count;
			jackHat = GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count;
			hookah = GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count;
			cheeseFood = GameObject.Find ("Cheese").GetComponent<UpgradeManager> ().count;
			boneFood = GameObject.Find ("Bone").GetComponent<UpgradeManager> ().count;
			grapeFood = GameObject.Find ("Grapes").GetComponent<UpgradeManager> ().count;
			birdhouse = GameObject.Find("Birdhouse").GetComponent<ItemManager>().count;
			boneMeatFood = GameObject.Find ("boneMeat").GetComponent<UpgradeManager> ().count;
			snailFood = GameObject.Find ("snail").GetComponent<UpgradeManager> ().count;
			donutFood = GameObject.Find ("donut").GetComponent<UpgradeManager> ().count;
			panelInfo1.gameObject.SetActive (false);
			panelInfo2.gameObject.SetActive (false);
			clickText.text = "Click Total: " + clickTotal;
			totalUpgrades.text = "Total Upgrades: " + upgradeCount;
			totalGold.text = "Total gold earned: " + totalGoldEarned;

		}

		//Debug.Log (panelInfo1.gameObject.activeInHierarchy);
		//PlayerPrefs.SetInt ("hat1", barrelHat);
		if (panelInfo2.gameObject.activeInHierarchy == true) {
			//Debug.Log(barrelHat);
			barrelHat = GameObject.Find ("Barrel").GetComponent<ItemManager> ().count;
			mimiHat = GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count;
			jackHat = GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count;
			birdhouse = GameObject.Find("Birdhouse").GetComponent<ItemManager>().count;
			hookah = GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count;
		} else if (panelInfo1.gameObject.activeInHierarchy == true) {
			cheeseFood = GameObject.Find ("Cheese").GetComponent<UpgradeManager> ().count;
			boneFood = GameObject.Find ("Bone").GetComponent<UpgradeManager> ().count;
			grapeFood = GameObject.Find ("Grapes").GetComponent<UpgradeManager> ().count;
			boneMeatFood = GameObject.Find ("boneMeat").GetComponent<UpgradeManager> ().count;
			snailFood = GameObject.Find ("snail").GetComponent<UpgradeManager> ().count;
			donutFood = GameObject.Find ("donut").GetComponent<UpgradeManager> ().count;

			//Debug.Log(grapeFood);
		}
		upgradeCount = birdhouse + barrelHat + mimiHat + jackHat + cheeseFood + grapeFood + boneFood + hookah + snailFood + boneMeatFood + donutFood;

		PlayerPrefs.SetFloat ("gold", currentGold);
		PlayerPrefs.SetFloat ("totalGold", totalGoldEarned);
		PlayerPrefs.SetInt ("clicks", clickTotal);


		clickText.text = "Click Total: " + clickTotal;
		totalUpgrades.text = "Total Upgrades: " + upgradeCount;
		totalGold.text = "Total gold earned: " + totalGoldEarned;

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
		if (panelHats == true) {
			panelInfo2.gameObject.SetActive(false);
			hat.sprite = HatOff;
			panelHats = false;
		}
		if (panelFood == false) 
		{
			food.sprite = FoodOn;
			panelInfo1.gameObject.SetActive(true);
			panelFood = true;
			//StartCoroutine(TestCoroutine(1));
			} 
		else
		{
			food.sprite = FoodOff;
			panelFood = false;
			panelInfo1.gameObject.SetActive(false);
			
		}
	
	}
	public void activatePanelHats()
	{
		if (panelFood == true) {
			panelInfo1.gameObject.SetActive(false);
			food.sprite = FoodOff;
			panelFood = false;
		}
		if (panelHats == false) 
		{
			hat.sprite = HatOn;
			panelInfo2.gameObject.SetActive(true);
			panelHats = true;
		} 
		else 
		{
			hat.sprite = HatOff;
			panelHats = false;
			panelInfo2.gameObject.SetActive(false);
		}

		
	}



}