using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WearHat2 : MonoBehaviour {
	private ItemManager itemmanager;
	private int currentCount;
	public bool hat2On;
	private int currentHat;
	public Sprite[] hats;
	
	void Start(){
		currentHat = GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().hatNumber;
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
	}
	
	// Use this for initialization
	void OnMouseDown() {
		
		currentCount = GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count;
		currentHat = GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().hatNumber;
		Debug.Log (currentHat);
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
		if (currentCount > 0) {
			Sprite sprite = GameObject.Find ("Nack mimi").GetComponent<ItemManager>().icons[currentHat];
			
			GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
			if (Input.GetMouseButtonDown (0)) {
				hat2On = true;
			}
		}
	}
}
