using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public int health;
	public GameObject explosionEffect;
	public GameObject[] hearts;
	public GameObject scoreboard;
	public GameObject scoreScript;

	private void Start (){
		ShowHearts();

		if (MePlayer ()) {
			ShowHearts ();
			scoreScript = FindObjectOfType<ScoreBoard> ().gameObject;
		}
	}
	private void ShowHearts(){
		//turn hearts off
		for (int i = 0; i < hearts.Length; i++) {
			hearts [i].SetActive (false);
		}
		//turn hearts on by health
		for (int i = 0; i < health; i++) {
			hearts [i].SetActive (true);
		}
	}

	private bool MePlayer(){
		if (GetComponent<PlayerController> ()) {
			return true;
		} else {
			return false;
		}
	}

	public void IncrementHealth(int damage){
		health += damage;
		ShowHearts();
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
			if (!MePlayer) {
				IncrementScore ();
			}
			if (MePlayer) {
				gameObject.GetComponent<PlayerController> ().LevelMangager.GetComponent<LevelManager> ().LoadNextLevel;
			}
		}
	}

	private void IncrementScore(){
		scoreboard.GetComponent<ScoreBoard> ().IncrementScoreBoard (10);
	}
}
