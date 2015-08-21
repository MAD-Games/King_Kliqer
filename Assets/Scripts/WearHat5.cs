using UnityEngine;
using System.Collections;

public class WearHat5 : MonoBehaviour {
	private ItemManager itemmanager;
	private int currentCount;
	public bool hat5On;
	
	
	// Update is called once per frame
	void OnMouseDown() {
		currentCount = GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count;
		if (currentCount > 0) {
			Sprite sprite = GetComponent<SpriteRenderer> ().sprite;
			GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
			if (Input.GetMouseButtonDown (0)) {
				hat5On = true;
			}
		}
}
}