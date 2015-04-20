using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ToolBoxV2 : MonoBehaviour {
	public Button[] buttons = new Button[4];
	//Populate in inspector with allowed tools for the level
	public List<GameObject> tools = new List<GameObject>(); 

	 
	// Use this for initialization
	void Start () {
		int i = 0;
		while (i < 4 && i < tools.Count){
			buttons[i].image.sprite = tools[i].GetComponent<ImageScript>().sprite;
			i++;
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void shiftRight(){
		Button temp = buttons [4];
		for (int i = 4; i > 0; i--) {
			buttons[i] = buttons[i-1];
		}
		buttons [0] = buttons [4];
	}
	public void shiftLeft(){

	}

	public void selectTool(){

	}
}
