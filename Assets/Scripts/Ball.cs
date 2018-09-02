using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float speed;
	private Vector2 topCorner, bottomCorner;
	private Rigidbody2D rigid2D;

	void Awake() {
		rigid2D = GetComponent<Rigidbody2D>();
	}

	void Start() {
		rigid2D.AddForce(Vector2.up * speed);
	}
	
}
