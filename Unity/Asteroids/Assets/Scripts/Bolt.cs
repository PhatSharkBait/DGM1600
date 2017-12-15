using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
    public int damage;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
        Destroy(gameObject, 2);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Health>().IncrementHealth(-damage);
        Destroy(gameObject);
    }
}
