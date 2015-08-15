using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	

	
	// Use this for initialization
	void Start () {	
	}
	
	public void OnMouseDownStart() {

		Destroy (this);
		Application.LoadLevel ("clicker");

	}

	//public void OnMouseDownExit() {
	//	Application.Quit ();
	//}

	//public void OnMouseDownTitle()
	//{
		//Destroy (gameObject.Find ("Main Camera"));
		//DestroyImmediate(Camera.main.gameObject);
	//	Application.LoadLevel ("title-new");

	//}

}
