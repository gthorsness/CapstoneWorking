using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hide_show : MonoBehaviour {
	public GameObject menu;
	private bool shown;
	// Use this for initialization
	void Start () {
		shown = false; 
		menu.SetActive (shown);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toggle(){
		//if shown then hide 
		if (shown) {
			shown = false;
			menu.SetActive(shown);
		} else {
			//reveal
			shown = true;
			menu.SetActive(shown);
		}

	}
}
