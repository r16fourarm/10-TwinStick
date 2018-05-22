using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
	float v,h;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			v = CrossPlatformInputManager.GetAxis("Vertical");
			h= CrossPlatformInputManager.GetAxis("Horizontal");
			Debug.Log("v :" + v);
			Debug.Log("h :" + h);
			
		
	}
}
