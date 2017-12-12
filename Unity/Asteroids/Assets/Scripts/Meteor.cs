using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

	public float startingSpin;
	public float speed;

	private GameObject player;
	private Rigidbody2D rigid;
    private GameObject PlayerCam;

    // Use this for initialization
    void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-0.5f, 0.5f), ForceMode2D.Impulse);
	
		player = FindObjectOfType<PlayerController> ().gameObject;
		rigid = GetComponent<Rigidbody2D> ();

		transform = transform.position =  player.transform.position;

		rigid.AddRelativeForce(new Vector2(Random.Range(0, speed),0f),ForceMode2D.Force);

		rigid.AddTorque(Random.Range(-startingSpin,startingSpin), ForceMode2D.Impulse);
	}

	public void OnCollisionEnter2D(Collision2D coll){
		coll.gameObject.GetComponent<Health> ().IncrementHealth (-1);
	}
		
}
