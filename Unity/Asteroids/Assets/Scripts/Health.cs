using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public GameObject explosionEffect;
	public GameObject scoreboard;
	public GameObject scoreScript;
    public GameObject LevelManager;
    public GameController gameController;
    public int scoreValue;
    public GameObject[] hearts;

    private void Start() {

        if (MePlayer ()) {
			ShowHearts ();
		}

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }

    }
    public void ShowHearts()
    {
        //Turn off all hearts
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(false);
        }

        //Turn hearts according to health
        for (int i = 0; i < health; i++)
        {
            hearts[i].SetActive(true);
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
        print(health);
        ShowHearts();
        if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
			if (!MePlayer()) {
				gameController.addScore (scoreValue);
                Destroy(gameObject);

			}
			if (MePlayer()) {
                LevelManager.GetComponent<LevelManager>().LoadNextLevel();
			}
		}
	}


}
