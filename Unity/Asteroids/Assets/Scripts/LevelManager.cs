using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void levelLoad(string level01){
		SceneManager.LoadScene (level01);
	}

	public void LoadNextLevel (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void quitGame(string Quit){
		print ("Exit");
		Application.Quit ();
	}
}
