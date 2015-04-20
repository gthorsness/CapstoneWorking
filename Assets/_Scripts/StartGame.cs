using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour 
{	
	public void LoadGame (string SceneName) 
	{
		Application.LoadLevel (SceneName);
	}
}
