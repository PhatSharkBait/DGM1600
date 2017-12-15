using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    public float startingSpin;
    public float speed;
    public int health;
    public int scoreValue;

    private Rigidbody2D rigid;
    private GameObject PlayerCam;
    private GameController gameController;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 5);
        rigid = gameObject.GetComponent<Rigidbody2D>();
        rigid.velocity = transform.up * speed;
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-0.5f, 0.5f), ForceMode2D.Impulse);

        rigid = GetComponent<Rigidbody2D>();

        rigid.AddRelativeForce(new Vector2(Random.Range(0, speed), 0f), ForceMode2D.Force);

        rigid.AddTorque(Random.Range(-startingSpin, startingSpin), ForceMode2D.Impulse);
    }

    public void OnCollision2D(Collision2D coll)
    {
        coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
    }

}
