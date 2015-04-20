using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Spikes : MonoBehaviour {
	public AudioClip popSound; 

	private AudioSource source;

	
	void Awake () {
		
		source = GetComponent<AudioSource>();
		
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Balloon") {
			source.PlayOneShot(popSound,0.5F);
			//animation i didn't get to work will try later
			//other.animation.Play();
			Destroy(other.gameObject);				
		}
	}

}
