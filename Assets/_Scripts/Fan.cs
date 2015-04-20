using UnityEngine;
using System.Collections;

public class Fan : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (rb.isKinematic==false&&other.gameObject.name != "wall" && other.gameObject.name != "Goal") {
			other.rigidbody.AddForce (transform.right*200);
		}
	}
}
