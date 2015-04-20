using UnityEngine;
using System.Collections;

public class CameraSizeandPosition : MonoBehaviour {
	float selectedScreenWidth = 9.0f;

	// Use this for initialization
	void Start () {
		float screenSize = selectedScreenWidth / Screen.width * Screen.height;
		screenSize = screenSize / (2f * Mathf.Tan (.5f * Camera.main.fieldOfView * Mathf.Deg2Rad));
		Vector3 cameraPosition= Camera.main.transform.position;
		cameraPosition.z = - screenSize;
		transform.position = cameraPosition;
	}
	
	// Update is called once per frame
	void Update () {
		float screenSize = selectedScreenWidth / Screen.width * Screen.height;
		screenSize = screenSize / (2f * Mathf.Tan (.5f * Camera.main.fieldOfView * Mathf.Deg2Rad));
		Vector3 cameraPosition= Camera.main.transform.position;
		cameraPosition.z = - screenSize;
		transform.position = cameraPosition;
	}
}
