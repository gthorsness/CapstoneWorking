using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = true;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		rigidbody.AddForce(0,20,0);
	}

	void OnTriggerEnter(Collider other) {

	}	
}
