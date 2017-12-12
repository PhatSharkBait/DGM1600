using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

	public Text display;
	public int score;
	public Text highscoreDisplay;
	public Text prevScoreDisplay;

	private void Start (){
		score = 0;
		if (display != null) {
			display.text = score.ToString ();
		}
		if (highscoreDisplay != null)
			highscoreDisplay.text = GetScore ().ToString ();
		if (prevScoreDisplay != null)
			prevScoreDisplay.text = PlayerPrefs.GetInt ("PrevScore").ToString ();;
	}

	public void SaveScore(){

		int oldScore = GetScore();
		PlayerPrefs.SetInt ("PrevScore", oldScore);

		if (score > oldScore)
			PlayerPrefs.SetInt ("HighScore", score);
	}

	public int GetScore(){
		return PlayerPrefs.GetInt ("HighScore");
	}

	public void OnDisable(){
		SaveScore ();
	}

	public void IncrementScoreBoard (int value){
		score += value;
		display.text = score.ToString();
	}
}
