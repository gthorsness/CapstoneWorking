﻿using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour 
{
	public void LoadCredits (string SceneName) 
	{
		Application.LoadLevel (SceneName);
	}
}
