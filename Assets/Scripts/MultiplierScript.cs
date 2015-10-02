using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MultiplierScript : MonoBehaviour {

	public int multiplier = 1;
	int count = 1;

	
	void Start(){
		int count = 1;
	}
	
	// Use this for initialization
	public void OnMouseDown() {

		count ++;

		if ((count % 3) == 2) {
			multiplier = 10;
			GameObject.Find("MultiText").GetComponent<Text>().text = "10X";
		}
		if ((count % 3) == 1) {
			multiplier = 1;
			GameObject.Find("MultiText").GetComponent<Text>().text = "1X";
		}
		if ((count % 3) == 0) {
			multiplier =100;
			GameObject.Find("MultiText").GetComponent<Text>().text = "100X";
		}

	}
	
	
}
