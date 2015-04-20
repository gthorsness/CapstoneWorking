using UnityEngine;
using System.Collections;

public class BalloonScript : MonoBehaviour {
	GameObject balloon;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ClickButton(string name){
		print ("hello");
		Debug.Log ("Clicked on " + name);
		balloon =(GameObject) Instantiate(Resources.Load("Balloon"),new Vector3(0,0,0), Quaternion.identity);
		balloon.AddComponent("DragDrop");
		;
	}
}
