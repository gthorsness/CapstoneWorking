using UnityEngine;
using System.Collections;

public class wieght100 : MonoBehaviour {
	private GameObject wieght;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ClickButton(string name){
		print ("hello");
		Debug.Log ("Clicked on " + name);
		wieght =(GameObject) Instantiate(Resources.Load("Wieght100"),new Vector3(0,0,0), Quaternion.identity);
		wieght.AddComponent("DragDrop");
	}
}
