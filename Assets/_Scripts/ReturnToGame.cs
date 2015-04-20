using UnityEngine;
using System.Collections;

public class ReturnToGame : MonoBehaviour 
{
	public void ReturnToGameScreen(string Level)
	{
		Application.LoadLevel(Level);
	}
}
