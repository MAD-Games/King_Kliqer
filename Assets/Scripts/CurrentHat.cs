using UnityEngine;
using System.Collections;

public class CurrentHat : MonoBehaviour {

	public GameObject hat1;
	public GameObject hat2;
	public GameObject hat3;
	public GameObject hat4;
	public GameObject hat5;
	public GameObject HatPosition;
	private ItemManager itemCount;

	Vector3 scale;
	Vector3 position;

	bool hat1On =false;
	bool hat2On = false;
	bool hat3On = false;
	bool hat4On = false;
	bool hat5On = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		hat1On = hat1.GetComponent<WearHat1> ().hat1On;
		hat2On = hat2.GetComponent<WearHat2> ().hat2On;
		hat3On = hat3.GetComponent<WearHat3> ().hat3On;
		hat4On = hat4.GetComponent<WearHat4> ().hat4On;
		hat5On = hat5.GetComponent<WearHat5> ().hat5On;
		if (hat1On == true) {

			if(GameObject.Find("Barrel").GetComponent<ItemManager>().count >= 0 &
			   GameObject.Find("Barrel").GetComponent<ItemManager> ().count < 10)
			{
				Debug.Log ("hello");
				hat1.GetComponent<WearHat1> ().hat1On = false;
				hat1On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3(0.07f, 2.41f, -1f);
				transform.localScale = scale;
				transform.localPosition = position;
			}
			else if(GameObject.Find ("Barrel").GetComponent<ItemManager> ().count >= 10 && 
			   GameObject.Find ("Barrel").GetComponent<ItemManager> ().count < 25)
			{
				Debug.Log ("hello");
				hat1.GetComponent<WearHat1> ().hat1On = false;
				hat1On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3(0.07f, 2.79f, -1f);
				transform.localScale = scale;
				transform.localPosition = position;
			}
			else
			{
				hat1.GetComponent<WearHat1> ().hat1On = false;
				hat1On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3(0.01f, 3.31f, -1f);
				transform.localScale = scale;
				transform.localPosition = position;
			}
			Debug.Log("hat1");

		}
		if (hat2On == true) {
			if(GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count >= 0 && 
			   GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count < 10)
			{
			hat2.GetComponent<WearHat2> ().hat2On = false;
			hat2On = false;
				scale = new Vector3 (1.0683581f, 1.10064f, 1f);
			position = new Vector3(0.27f, 3.21f, -.32f);
			transform.localPosition = position;
			transform.localScale = scale;
			}
			if(GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count >= 10 && 
			   GameObject.Find ("Nack mimi").GetComponent<ItemManager> ().count < 25)
			{
				hat2.GetComponent<WearHat2> ().hat2On = false;
				hat2On = false;
				scale = new Vector3 (1.068358f, 1.10064f, 1f);
				position = new Vector3(0.31f, 3.53f, -.32f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
			else{
				hat2.GetComponent<WearHat2> ().hat2On = false;
				hat2On = false;
				scale = new Vector3 (1.068358f, 1.10064f, 1f);
				position = new Vector3(0.21f, 3.22f, -.32f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
			//Debug.Log("hat2");

		}
		if (hat3On == true) {
			if (GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count >= 0 && 
				GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count < 10) {
				hat3.GetComponent<WearHat3> ().hat3On = false;
				hat3On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3 (0.24f, 4.5f, -1f);
				transform.localPosition = position;
				transform.localScale = scale;
			} else if (GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count >= 10 && 
				GameObject.Find ("Jack ripper").GetComponent<ItemManager> ().count < 25) {
				hat3.GetComponent<WearHat3> ().hat3On = false;
				hat3On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3 (0.24f, 4.5f, -1f);
				transform.localPosition = position;
				transform.localScale = scale;
			} else {
				hat3.GetComponent<WearHat3> ().hat3On = false;
				hat3On = false;
				scale = new Vector3 (.8049842f, 1.010508f, 1f);
				position = new Vector3 (0.62f, 4.78f, -1f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
		}

			if (hat4On == true) {
			if (GameObject.Find ("Birdhouse").GetComponent<ItemManager> ().count >= 0 && 
				GameObject.Find ("Birdhouse").GetComponent<ItemManager> ().count < 10) {
				hat4.GetComponent<WearHat4> ().hat4On = false;
				Debug.Log("hello");
				hat4On = false;
				scale = new Vector3 (1.068358f, 1.0063f, 1f);
				position = new Vector3 (.44f, 4.62f, -0.32f);
				transform.localPosition = position;
				transform.localScale = scale;
			} else if (GameObject.Find ("Birdhouse").GetComponent<ItemManager> ().count >= 10 && 
				GameObject.Find ("Birdhouse").GetComponent<ItemManager> ().count < 25) {
				hat4.GetComponent<WearHat4> ().hat4On = false;
				hat4On = false;
				scale = new Vector3 (1.068358f, 1.0063f, 1f);
				position = new Vector3 (0.2f, 4.9f, -0.32f);
				transform.localPosition = position;
				transform.localScale = scale;
			} else {
				hat4.GetComponent<WearHat4> ().hat4On = false;
				hat4On = false;
				scale = new Vector3 (1.068358f, 1.0063f, 1f);
				position = new Vector3 (0.2f, 4.9f, -0.32f);
				transform.localPosition = position;
				transform.localScale = scale;
			}
		}

				if (hat5On == true) {
					if(GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count >= 0 && 
					   GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count < 10)
					{
						hat5.GetComponent<WearHat5> ().hat5On = false;
						hat5On = false;
						scale = new Vector3 (1.068358f, 1.0063f, 1f);
						position = new Vector3(0.2f, 1.93f, -0.32f);
						transform.localPosition = position;
						transform.localScale = scale;
					}
					else if(GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count >= 10 && 
					        GameObject.Find ("hookaHat").GetComponent<ItemManager> ().count < 25)
					{
						hat5.GetComponent<WearHat5> ().hat5On = false;
						hat5On = false;
						scale = new Vector3 (1.068358f, 1.0063f, 1f);
						position = new Vector3(0.65f, 2.26f, -0.32f);
						transform.localPosition = position;
						transform.localScale = scale;
					}
					else
					{
						hat5.GetComponent<WearHat5> ().hat5On = false;
						hat5On = false;
						scale = new Vector3 (1.068358f, 1.0063f, 1f);
						position = new Vector3(0.44f, 1.89f, -0.32f);
						transform.localPosition = position;
						transform.localScale = scale;
					}
			//Debug.Log("hat3");

			}
			
		}
	

}
