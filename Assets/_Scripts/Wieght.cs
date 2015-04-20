using UnityEngine;
using System.Collections;

public class Wieght : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = true;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
