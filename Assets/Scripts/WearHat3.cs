using UnityEngine;
using System.Collections;

public class WearHat3 : MonoBehaviour {
	public bool hat3On;
	private int currentCount;


	// Update is called once per frame
	void OnMouseDown() {
		currentCount = GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count;
		if (currentCount > 0) {
			Sprite sprite = GetComponent<SpriteRenderer> ().sprite;
			GameObject.Find ("CurrentHat").GetComponent<SpriteRenderer> ().sprite = sprite;
			if (Input.GetMouseButtonDown (0)) {
				hat3On = true;
			}
			//Vector3 scale = new Vector3 (positionX, height, 1f);
			//transform.localScale = scale;
			//transform.position = position;

		}
	
	}
}
