using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	public enum Type {laser, shield, speed};
	public Type powerupType;
	public Sprite[] images;
	// Use this for initialization
	void Start () {
		switch (powerupType) {
		case Type.laser:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		case Type.shield:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [1];
			break;
		default:
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("We hit a powerup");

		if (powerupType == Type.laser) {
		
		}
		switch (powerupType) {
		case Type.speed:
			other.GetComponent<PlayerController> ().speed *= 2;
			break;
		case Type.laser:
			other.GetComponent<PlayerController> ().damage *= 2;
			break;
		case Type.shield:
			other.GetComponent<PlayerController> ().health *= 2;
			break;
		default:
			break;
		}
		Destroy (this.gameObject);
	}
}
