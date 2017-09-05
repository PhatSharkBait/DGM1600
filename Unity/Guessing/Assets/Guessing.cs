using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guessing : MonoBehaviour {


	int max = 100;
	int min = 0;
	int guess = 50;	


	// Use this for initialization
	void Start () {
		

		print ("Welcome to Number Guesser");
		print ("Think of a number.");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up  arrow for higher, Down for lower, Enter for equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess + 1;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess - 1;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess);
		}
		if (Input.GetKeyDown(KeyCode.Return)){
			print ("Your number is " + guess);
		}
	}
}
