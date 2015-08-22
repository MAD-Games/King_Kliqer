using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WearHat4 : MonoBehaviour {
	private ItemManager itemmanager;
	private int currentCount;
	private int currentHat;
	public bool hat4On;
	public Sprite[] hats;
	
	void Start(){
		currentHat = GameObject.Find ("Birdhouse").GetComponent<ItemManager> ().hatNumber;
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
	}
	
	// Use this for initialization
	void OnMouseDown() {
		
		currentCount = GameObject.Find ("Birdhouse").GetComponent<ItemManager> ().count;
		currentHat = GameObject.Find ("Birdhouse").GetComponent<ItemManager> ().hatNumber;
		Debug.Log (currentHat);
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
		if (currentCount > 0) {
			Sprite sprite = GameObject.Find ("Birdhouse").GetComponent<ItemManager>().icons[currentHat];

			GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
			if (Input.GetMouseButtonDown (0)) {
				hat4On = true;
			}
		}
	}
}
