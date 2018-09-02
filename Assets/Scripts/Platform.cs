using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public float speed = 4.75f;

	private float minX, maxX;
	private BoxCollider2D box2D;
	private Vector2 topCorner, bottomCorner;

	public void ToLeft() {
		if(minX < transform.position.x) {
			Move(-1);
		}
	}

	public void ToRight() {
		if(transform.position.x < maxX) {
			Move(1);
		}
	}

	public void Move(float dir) {
		transform.position = Vector3.Lerp(
			transform.position, 
			transform.position + (Vector3.right * dir), 
			Time.deltaTime * speed
		);
	}

	void Awake() {
		box2D = GetComponent<BoxCollider2D>();
		
		bottomCorner = ScreenBoundaries.CalcBottomCorner(transform.position);
		topCorner = ScreenBoundaries.CalcTopCorner(transform.position);
		
		float addition = box2D.size.x * transform.localScale.x / 2;
		minX = bottomCorner.x + addition;
		maxX = topCorner.x -  addition;
	}

	void Update() {

		Vector3 pos = transform.position;

		if(Input.GetKey(KeyCode.LeftArrow)) {
			ToLeft();
		}

		if(Input.GetKey(KeyCode.RightArrow)) {
			ToRight();
		}
	}
}
