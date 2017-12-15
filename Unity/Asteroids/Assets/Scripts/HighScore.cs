using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

    public TextMesh highScoreText;
    // Use this for initialization
    void Start () {
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
