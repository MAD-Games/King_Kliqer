using UnityEngine;
using System.Collections;

public class WearHat2 : MonoBehaviour {

	public bool hat2On;
	

	// Update is called once per frame
	void OnMouseDown() {
		Sprite sprite = GetComponent<SpriteRenderer>().sprite;
		GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
		if (Input.GetMouseButtonDown (0)) {
			hat2On = true;
		}
	}
}
