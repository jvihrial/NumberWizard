﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me.");
		
		int max = 1000;
		int min = 1;	
		
		print ("Highest number you can enter is " + max );
		print ("..and lowest nuber is " + min );
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
