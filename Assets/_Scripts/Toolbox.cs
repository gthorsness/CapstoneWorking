using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Toolbox : MonoBehaviour {
	private bool toolboxWindow = false;
	private Rect toolboxWindowRect = new Rect((Screen.width / 2)-(Screen.width/4),
	                                          (Screen.height/2)-(Screen.height/3),(Screen.width / 2),
	                                           (2*Screen.height) / 3);

	static public Dictionary<int,string> toolBoxDictionary = new Dictionary<int ,string >(){
		{0,string.Empty},
		{1,string.Empty},
		{2,string.Empty},
		{3,string.Empty}
	};
	static public List<int> toolBoxAmount = new List<int>(){
		0,
		0,
		0
	};

	ToolCreatorClass toolbox = new ToolCreatorClass();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		toolboxWindow = GUI.Toggle (new Rect (750,15,100,100), toolboxWindow, "Toolbox");
				if (toolboxWindow) {
						toolboxWindowRect = GUI.Window (0, toolboxWindowRect, toolboxWindowMethod, "TOOLS");
				}
		}
	void toolboxWindowMethod(int toolID){
		Rect boxWindowSize;
		GUILayout.BeginArea (boxWindowSize = new Rect(8,20,toolboxWindowRect.width-20,toolboxWindowRect.height-40));

		GUILayout.BeginVertical ();
		GUILayout.Button ("Fan", GUILayout.Height (30),GUILayout.Width(boxWindowSize.width) );
		GUILayout.Box (toolBoxAmount [0].ToString(), GUILayout.Height (30), GUILayout.Width (boxWindowSize.width));

		GUILayout.Button ("Balloon", GUILayout.Height (30),GUILayout.Width(toolboxWindowRect.width));
		GUILayout.Box (toolBoxAmount [1].ToString(), GUILayout.Height (30), GUILayout.Width (boxWindowSize.width));

		GUILayout.Button ("meh", GUILayout.Height (30),GUILayout.Width(boxWindowSize.width));
		GUILayout.Box (toolBoxAmount [2].ToString(), GUILayout.Height (30), GUILayout.Width (boxWindowSize.width));
		GUILayout.EndVertical ();
		GUILayout.EndArea ();
	}

}
