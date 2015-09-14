using UnityEngine;
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
		
		print ("Is your number greater or lower than 500 ?");
		print ("Press up arrow for higher, down for lower and enter for equal");
		
	}
	
	// Update is called once per frame
	void Update () {
			
		if (Input.GetKeyDown( KeyCode.UpArrow)) {
			print ("Up arrow pressed");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow pressed");
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Enter key pressed");
		}
		
	}		
}
