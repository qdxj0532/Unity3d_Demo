﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.skin.label.fontSize = 100;

		GUI.Label (new Rect (10, 10, Screen.width, Screen.height), "my hello world from NewBehaviourScript");
	}
}
