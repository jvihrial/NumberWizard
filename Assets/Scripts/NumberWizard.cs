using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	public int max, min;
	public int guess = 500;	

	// Use this for initialization
	void Start () {
	
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me.");
		
		max = 1001; // 1000 is the count, but due to rounding problem (when dividing) we cannot get to 1000.
		min = 1;	
		
		print ("Highest number you can enter is " + max );
		print ("..and lowest nuber is " + min );
		
		print ("Is your number greater or lower than " + guess + " ?");
		print ("Press up arrow for higher, down for lower and enter for equal");
		
	}
	
	// Update is called once per frame
	void Update () {
			
		if (Input.GetKeyDown( KeyCode.UpArrow)) {
			//print ("Up arrow pressed");
			min = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down arrow pressed");
			max = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);		
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Enter key pressed (I won ;) !)");
		}
		
	}		
}
