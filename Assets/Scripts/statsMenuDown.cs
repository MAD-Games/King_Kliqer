using UnityEngine;
using System.Collections;

public class statsMenuDown : MonoBehaviour {
	Animator anime;
	public bool menuDown;
	//bool checkMenuDown;

	// Use this for initialization
	void Start () {
		anime = GameObject.Find("statsWindow").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}

	public void onMenuDown()
	{
			anime.SetTrigger ("menuDown");
			menuDown = true;
		
	}

}
