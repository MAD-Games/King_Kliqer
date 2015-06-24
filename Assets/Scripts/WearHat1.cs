using UnityEngine;
using System.Collections;

public class WearHat1 : MonoBehaviour {

	public bool hat1On;
	
	// Use this for initialization
	void OnMouseDown() {
		Sprite sprite = GetComponent<SpriteRenderer>().sprite;
		GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
		if (Input.GetMouseButtonDown (0)) {
			hat1On = true;
		}
	}


}
