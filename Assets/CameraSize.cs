using UnityEngine;
using System.Collections;

public class CameraSize : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Vector3 pov = new Vector3(Screen.width, Screen.height, -10.0f);
		Camera.main.transform.position = pov;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
