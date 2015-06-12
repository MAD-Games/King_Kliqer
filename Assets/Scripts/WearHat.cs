using UnityEngine;
using System.Collections;

public class WearHat : MonoBehaviour {

	private string icon;
	
	// Use this for initialization
	void Start () {	
	}
	
	void OnMouseDown() {
		Sprite sprite = GetComponent<SpriteRenderer>().sprite;
		GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
	}
}
