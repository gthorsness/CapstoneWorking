using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour 
{	
	public void LoadInstructions (string SceneName) 
	{
		Application.LoadLevel (SceneName);
	}
}
