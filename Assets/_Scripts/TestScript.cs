using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour 
{
	Vector3 startPos;
	public static float distanceTraveled;
	// Use this for initialization
	void Start () 
	{
		startPos=transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(5f * Time.deltaTime, 0f, 0f);
		distanceTraveled = transform.localPosition.x;
		if( gameObject.transform.position.x >= 17) 
		{
			transform.position = startPos; 
		}
	}
}
