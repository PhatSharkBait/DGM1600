using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

	public float paddleHeight;

	private Transform paddleTrans;
	// Use this for initialization
	void Start () {
		paddleTrans = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos.y = paddleHeight;
		mousePos.z = 0;
		paddleTrans.position = mousePos;
	}
}
