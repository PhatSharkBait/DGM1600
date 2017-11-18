using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int brickCount;

	void Start(){
		brickCount = FindObjectsOfType<Health> ().Length;
		print (brickCount);
	}

	public void levelLoad(string level01){
		SceneManager.LoadScene (level01);
	}

	public void quitGame(string Quit){
		print ("Exit");
		Application.Quit ();
	}

	public void LoadNextLevel (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void CheckBrickCount (){
		brickCount = FindObjectsOfType<Health> ().Length - 1;
		print (brickCount);
		if (brickCount <= 0) {
			LoadNextLevel ();
		}
	}
}
