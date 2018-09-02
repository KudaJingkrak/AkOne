using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Vector2 topCorner, bottomCorner;

	void Awake() {
		bottomCorner = ScreenBoundaries.CalcBottomCorner(transform.position);
		topCorner = ScreenBoundaries.CalcTopCorner(transform.position);
	}
}
