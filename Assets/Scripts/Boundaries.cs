using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {
	BoxCollider2D box2D;

	void Awake()
	{
		transform.position = Vector3.zero;
		// box2D = GetComponent<BoxCollider2D>();
		// box2D.size = ScreenBoundaries.CalcTopCorner(transform.position) * 2;
	}
}
