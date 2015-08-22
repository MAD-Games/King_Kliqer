using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WearHat5 : MonoBehaviour {
	private ItemManager itemmanager;
	private int currentCount;
	public bool hat5On;
	private int currentHat;
	public Sprite[] hats;
	
	void Start(){
		currentHat = GameObject.Find ("hookaHat").GetComponent<ItemManager> ().hatNumber;
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
	}
	
	// Use this for initialization
	void OnMouseDown() {
		
		currentCount = GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count;
		currentHat = GameObject.Find ("hookaHat").GetComponent<ItemManager> ().hatNumber;
		Debug.Log (currentHat);
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
		if (currentCount > 0) {
			Sprite sprite = GameObject.Find ("hookaHat").GetComponent<ItemManager>().icons[currentHat];
			
			GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
			if (Input.GetMouseButtonDown (0)) {
				hat5On = true;
			}
		}
}
}