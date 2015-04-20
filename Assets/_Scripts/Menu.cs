using UnityEngine;
using System.Collections;
// Title Screen Menu
public class Menu : MonoBehaviour {
	void OnGUI(){
				int buttonWidth = 80;
				int buttonHeight = 60;
				//Dyamically Creates a button at the beginning of the menu 
				Rect startButton = new Rect ((Screen.width / 2) - (buttonWidth / 2),
		                            (2 * Screen.height) / 3 - (buttonHeight / 2),
		                            buttonWidth, buttonHeight);
				if (GUI.Button (startButton, "Start Game")) {
						// Load the 1st level of the game
						Application.LoadLevel ("levelOne");
				}
		}
	}
