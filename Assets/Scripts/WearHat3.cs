using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WearHat3 : MonoBehaviour {
	public bool hat3On;
	private int currentCount;
	private int currentHat;
	public Sprite[] hats;
	
	void Start(){
		currentHat = GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().hatNumber;
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
	}
	
	// Use this for initialization
	void OnMouseDown() {
		
		currentCount = GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count;
		currentHat = GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().hatNumber;
		Debug.Log (currentHat);
		this.gameObject.GetComponent<Image>().sprite = hats[currentHat];
		if (currentCount > 0) {
			Sprite sprite = GameObject.Find ("Jack ripper").GetComponent<ItemManager>().icons[currentHat];
			
			GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
			if (Input.GetMouseButtonDown (0)) {
				hat3On = true;
			}
		}
	
	}
}
