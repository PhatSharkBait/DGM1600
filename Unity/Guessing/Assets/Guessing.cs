using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Guessing : MonoBehaviour {

	public Text textBox;


	private int max = 100;
	private int min = 0;
	private int guess;	

	public int counter;


	// Use this for initialization
	void Start () {
		
		guess = Random.Range (min, max);


		textBox.text = "Welcome to Number Guesser" +
			"\nThink of a number." +
			"\n\nThe Highest number you can pick is " + max +
			"\nThe Lowest number you can pick is " + min +
			"\n\nIs the number higher or lower than " + guess + "?" +
			"\nUp  arrow for higher, Down for lower, Enter for equal";


		print ("Welcome to Number Guesser");
		print ("Think of a number.");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up  arrow for higher, Down for lower, Enter for equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (counter == -1) {
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
				textBox.text = "You Win" +
				"\n\nPress Return to play again" +
				"\nPress Escape to close the game";
				print ("You Win");
				counter--;
			}
		}
		if (counter == -2) {
			if (Input.GetKeyDown (KeyCode.Return)) {
				SceneManager.LoadScene("Main");
			} 
			else if (Input.GetKeyDown (KeyCode.Escape)) {
				Application.Quit ();
			}
		}
			
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
				min = guess + 1;
				guess = (max + min) / 2;
				counter--;

				textBox.text = "I have " + counter + " guesses left" +
				"\n\nIs the number higher or lower than " + guess;

				print (counter + " Guesses Left");
				print ("Is the number higher or lower than " + guess);
			}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				max = guess - 1;
				guess = (max + min) / 2;
				counter--;

				textBox.text = "I have " + counter + " guesses left" +
				"\n\nIs the number higher or lower than " + guess;

				print (counter + " Guesses Left");
				print ("Is the number higher or lower than " + guess);
			}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			textBox.text = "Your number is " + guess +
			"\n\nI Win";			

				print ("Your number is " + guess);
				print ("I win");
			}
		
		if (counter == 0) {
			counter--;
		}
	}

}
