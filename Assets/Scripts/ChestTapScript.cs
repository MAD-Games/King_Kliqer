using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChestTapScript : MonoBehaviour {
	private Animator anime;
	private GameManager gameManager;
	public Text GPCText;
	public Text goldDisplay;
	public int goldPerClick = 0;
	public int clickTotal;
	public AudioSource chest;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		goldDisplay = GameObject.Find ("GoldDisplay").GetComponent<Text>();
		GPCText = GameObject.Find ("GPCText").GetComponent<Text>();
		anime = GetComponent<Animator> ();
		chest = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		goldDisplay.text = "Gold: " + GameManager.FormatNumber(gameManager.currentGold);
		GPCText.text = GameManager.FormatNumber(goldPerClick) + " gold/click";
	}

	void OnMouseDown() {
		anime.SetTrigger("Tap");
		gameManager.currentGold += goldPerClick;
		gameManager.clickTotal ++;
		chest.Play ();
	}

	void playSound(){
		//Chest.
	}
}
