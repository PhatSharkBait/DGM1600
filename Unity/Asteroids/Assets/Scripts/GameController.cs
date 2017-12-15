using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float WaveWait;

    public TextMesh scoreText;
    public TextMesh highScoreText;
    private int score;

    void Start() {
        score = 0;
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        incrementScore();
        StartCoroutine (SpawnWaves());
    }

    IEnumerator SpawnWaves() {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(WaveWait);
        }
    }

    public void addScore(int newScoreValue) {
        score += newScoreValue;
        incrementScore();
    }

    public void incrementScore() {
        scoreText.text = "Score: " + score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }
}
