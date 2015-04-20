using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pauseOnclick : MonoBehaviour {
	public Button myBtn;
	public Sprite pauseImage;
	public Sprite playImage;

	private bool paused;
	// Use this for initialization
	void Start () {
		paused = false;
		myBtn.image.sprite = pauseImage;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void pause(){
		if (paused == false) {
			Time.timeScale = 0;
			myBtn.image.sprite = playImage;
			paused = true;
		}else{
			Time.timeScale = 1;
			myBtn.image.sprite = pauseImage;
			paused = false;
		}
	}

	public void replay(){
		Application.LoadLevel(Application.loadedLevel);
		paused = false;
	}
}
