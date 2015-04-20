using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class testOnclick : MonoBehaviour {
	GameObject fans;
	public Transform fan;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	} 
	public void ClickButton(string name){
		print ("hello");
		Debug.Log ("Clicked on " + name);
		fans =(GameObject) Instantiate(Resources.Load("Fan"),new Vector3(0,0,0), Quaternion.identity);
		fans.AddComponent("DragDrop");
		;
	}
}
