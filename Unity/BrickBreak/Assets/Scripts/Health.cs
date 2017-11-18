using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health = 1;
	public Sprite[] bricks;
	public int count = 0;
	private LevelManager levelManager;

	void Start(){
		levelManager = FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D (Collision2D collider){ 
		health --;
		count = count + 1;
		if (health <= 0){
			levelManager.CheckBrickCount ();
			Destroy (this.gameObject);
		}
		GetComponent<SpriteRenderer> ().sprite = bricks[count];
	}
}
