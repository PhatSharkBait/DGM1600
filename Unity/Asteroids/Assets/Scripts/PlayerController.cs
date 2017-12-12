using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private GameObject player;
	public float speed;
	private Transform playerTrans;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public float spawnDist;
	public int damage;
	public int health;
	public ParticleSystem thruster;



	void Start () {
		playerTrans = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonUp("Fire1")) {
			GameObject shot = Instantiate(projectile, shotPos.position * spawnDist, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			print ("LEEEEEFT");
			Vector3 position = this.transform.position;
			position.x = position.x - speed;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			print ("RIIIIGHHT");
			Vector3 position = this.transform.position;
			position.x = position.x + speed;
			this.transform.position = position;

		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			print ("RIIIIGHHT");
			Vector3 position = this.transform.position;
			position.y = position.y + speed;
			this.transform.position = position;

		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			print ("RIIIIGHHT");
			Vector3 position = this.transform.position;
			position.y = position.y - speed;
			this.transform.position = position;

		}
	}
}