using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	private SpriteRenderer _render;

	void OnEnable() {
		_render = GetComponent<SpriteRenderer>();
	}
	
	void Awake() {
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
