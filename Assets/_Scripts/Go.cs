using UnityEngine;
using System.Collections;

public class Go : MonoBehaviour {
	private FixedJoint balloonJoint;
	public GameObject ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartPhysics(){
		GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
		foreach (GameObject go in allObjects) {
			if(go.tag == "Tool"||go.tag =="Balloon"){
				if (go.rigidbody.isKinematic  == true){
					go.rigidbody.isKinematic = false;
					//to get everything moving
					go.rigidbody.AddForce(0,0,1);
				}
				if(go.tag == "Balloon"){
					balloonJoint = go.AddComponent<FixedJoint>();
					balloonJoint.connectedBody = ball.rigidbody;
				}
			}
		}
	}
}