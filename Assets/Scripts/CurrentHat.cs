using UnityEngine;
using System.Collections;

public class CurrentHat : MonoBehaviour {

	public GameObject hat1;
	public GameObject hat2;
	public GameObject hat3;
	public GameObject HatPosition;
	private ItemManager itemCount;

	Vector3 scale;
	Vector3 position;

	bool hat1On;
	bool hat2On;
	bool hat3On;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		hat1On = hat1.GetComponent<WearHat1> ().hat1On;
		hat2On = hat2.GetComponent<WearHat2> ().hat2On;
		hat3On = hat3.GetComponent<WearHat3> ().hat3On;
		if (hat1On == true) {
			if(GameObject.Find ("Barrel").GetComponent<ItemManager> ().count >= 0 && 
			   GameObject.Find ("Barrel").GetComponent<ItemManager> ().count < 10)
			{
			hat1.GetComponent<WearHat1> ().hat1On = false;
			hat1On = false;
			scale = new Vector3 (.8049842f, 1.010508f, 1f);
			position = new Vector3(0.07f, 2.41f, 0f);
			transform.localScale = scale;
			transform.localPosition = position;
			}
			else if(GameObject.Find ("Barrel").GetComponent<ItemManager> ().count >= 10 && 
			   GameObject.Find ("Barrel").GetComponent<ItemManager> ().count < 25)
			{
				hat1.GetComponent<WearHat1> ().hat1On = false;
				hat1On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3(0.07f, 2.79f, 0f);
				transform.localScale = scale;
				transform.localPosition = position;
			}
			else
			{
				hat1.GetComponent<WearHat1> ().hat1On = false;
				hat1On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3(0.01f, 3.31f, 0f);
				transform.localScale = scale;
				transform.localPosition = position;
			}
			//Debug.Log("hat1");

		}
		if (hat2On == true) {
			if(GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count >= 0 && 
			   GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count < 10)
			{
			hat2.GetComponent<WearHat2> ().hat2On = false;
			hat2On = false;
			scale = new Vector3 (.8978831f, 1.072058f, 1f);
			position = new Vector3(0.12f, 3.27f, 0f);
			transform.localPosition = position;
			transform.localScale = scale;
			}
			if(GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count >= 10 && 
			   GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count < 25)
			{
				hat2.GetComponent<WearHat2> ().hat2On = false;
				hat2On = false;
				scale = new Vector3 (.8978831f, 1.072058f, 1f);
				position = new Vector3(0.17f, 3.46f, 0f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
			else{
				hat2.GetComponent<WearHat2> ().hat2On = false;
				hat2On = false;
				scale = new Vector3 (.897007f, 1.010508f, 1f);
				position = new Vector3(0.05f, 3.25f, 0f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
			//Debug.Log("hat2");

		}
		if (hat3On == true) {
			if(GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count >= 0 && 
			   GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count < 10)
			{
			hat3.GetComponent<WearHat3> ().hat3On = false;
			hat3On = false;
			scale = new Vector3 (.8049842f, 1.010508f, 1f);
			position = new Vector3(0.24f, 4.5f, 0f);
			transform.localPosition = position;
			transform.localScale = scale;
			}
			else if(GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count >= 10 && 
			   GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count < 25)
			{
				hat3.GetComponent<WearHat3> ().hat3On = false;
				hat3On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3(0.24f, 4.5f, 0f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
			else
			{
				hat3.GetComponent<WearHat3> ().hat3On = false;
				hat3On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3(0.62f, 4.78f, 0f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
			//Debug.Log("hat3");


		}
	
	}
}
