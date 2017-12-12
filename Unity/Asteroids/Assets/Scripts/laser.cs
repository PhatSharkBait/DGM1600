using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

	public float lifetime;
	public float speed;
	public int damage;
	public AudioSource audio;
	public PlayerController playerControllerScript;

	// Use this for initialization
	void Start () {
		playerControllerScript = GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		lifetime -= Time.fixedDeltaTime;
		if (lifetime <= 0) {
			Destroy(this.gameObject);
		}

		transform.Translate (Vector3.up * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other){
		other.GetComponent<Health> ().IncrementHealth(damage);
		Destroy (gameObject);
	}
}
