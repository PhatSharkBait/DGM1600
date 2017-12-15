using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour {

    public float speed;
    public int damage;
    public int health;
    private Rigidbody2D player;
    public Boundary boundary;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    private AudioSource pew;

    void Start() {
        player = gameObject.GetComponent<Rigidbody2D>();
        player.freezeRotation = true;
    }
        void Update() {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            pew = gameObject.GetComponent<AudioSource>();
            pew.pitch = Random.Range(2f, 4f);
            pew.Play();
        }
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        player = gameObject.GetComponent<Rigidbody2D>();
        gameObject.GetComponent<Rigidbody2D>().velocity = movement * speed;
        gameObject.GetComponent<Rigidbody2D>().position = new Vector3(
            Mathf.Clamp(player.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(player.position.y, boundary.yMin, boundary.yMax),
            0.0f);
    }

    public void OnCollisionEnter2D(Collision2D coll) {

        coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
        gameObject.GetComponent<Health>().IncrementHealth(-1);

    }
}