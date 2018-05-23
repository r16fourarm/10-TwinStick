using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	
	public bool recording =true;
	public bool Paused = false;

	private float initialTimestep;
	// Use this for initialization
	void Start () {
		initialTimestep = Time.fixedDeltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton("Fire1")) {
			recording = false;
		}
		else {
			recording = true;
		}

		if (Input.GetKeyDown(KeyCode.P)) {
			PauseGame ();
		}
		print("update");
	}

	void PauseGame () {
		if(!Paused){
			Paused = true;
			Time.timeScale = 0;
			Time.fixedDeltaTime = 0;
		}
		else {
			Paused = false;
			Time.timeScale = 1;
			Time.fixedDeltaTime = initialTimestep;
		}

	}
}
