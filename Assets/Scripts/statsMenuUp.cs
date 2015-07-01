using UnityEngine;
using System.Collections;

public class statsMenuUp : MonoBehaviour {
	Animator anime;

	
	// Use this for initialization
	void Start () {
		anime = GameObject.Find("statsWindow").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void OnMouseDown() {


		anime.SetTrigger("menuUp");
		Debug.Log ("test");

	}


	// Use this for initialization

}
