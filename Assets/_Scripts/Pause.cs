using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	public bool canPause;
	public Texture2D Pause_Button;
	public Texture2D Play_Button;
	public Texture2D Replay_Button;
	
	void Start () 
	{
		canPause = true;
	}

	void OnGUI () 
	{
		if (GUI.Button (new Rect (600, 15, 100, 50), Pause_Button)) 
		{
			if (canPause)
			{
				Time.timeScale = 0;
				canPause = false;
			}
			else
			{
				Time.timeScale = 1;
				canPause = true;
			}

		}
		if (GUI.Button (new Rect (400, 15, 100, 50), Replay_Button))
		{
			Application.LoadLevel(Application.loadedLevel);

			Time.timeScale = 0;
			canPause = false;
		}

		if (GUI.Button (new Rect (500, 15, 100, 50), Play_Button))
		{
			Time.timeScale = 1;
			canPause = true;
		}
	}
}
