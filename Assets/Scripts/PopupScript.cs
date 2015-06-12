using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour {

	public bool panelFood = false;
	public bool panelHats = false;
	public Transform panel;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void activatePanelFood()
	{
		if (panelFood == false && panelHats == true) 
		{
			GameObject.Find ("hatUpgradesPopup").SetActive(false);
			GameObject.Find ("foodUpgradesPopup").SetActive(true);
			panelFood = true;

		} 
		else if (panelFood == true) 
		{
			panelFood = false;
			GameObject.Find ("foodUpgradesPopup").SetActive(false);

		}
		else if (panelFood == false) 
		{
			panelFood = true;
			GameObject.Find ("foodUpgradesPopup").SetActive(true);

		}
	}
	public void activatePanelHats()
	{
		if (panelFood == true && panelHats == false) 
		{
			GameObject.Find ("foodUpgradesPopup").SetActive(false);
			GameObject.Find ("hatUpgradesPopup").SetActive(true);
			panelHats = true;
		} 
		else if (panelHats == true) 
		{
			panelHats = false;
			GameObject.Find ("hatUpgradesPopup").SetActive(false);
		}
		else if (panelHats == false) 
		{
			panelHats = true;
			GameObject.Find ("hatUpgradesPopup").SetActive(true);
		}

	}
}
