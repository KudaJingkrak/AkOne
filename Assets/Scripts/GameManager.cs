using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private int _score = 0;
	private float _collisionCount = 0f;
	private List<Ball> _balls = new List<Ball>();
	private Platform _platform = null;
	private static GameManager _instance;
	void Awake() {
		if (_instance == null) {
			_instance = this;
		} else if (_instance != this) {
			Destroy(this.gameObject);
		}

		DontDestroyOnLoad(this.gameObject);
	}

	public static List<Ball> GetBalls() {
		return _instance._balls;
	}

	public static Ball GetBall(int index = -1) {
		if (index == -1) {
			if(_instance._balls.Count > 0) {
				return _instance._balls[0];
			}
		}

		if(index < 0 || index > _instance._balls.Count) {
			return null;
		}

		return _instance._balls[index];
	}

	public static void AddBall(Ball ball) {
		_instance._balls.Add(ball);
	}

	public static void RemoveBall(Ball ball) {
		_instance._balls.Remove(ball);
	}

	public static void RemoveBall(int index) {
		if(index < 0 || index > _instance._balls.Count) {
			return;
		}

		_instance._balls.RemoveAt(index);
	}

	public static void ClearBalls() {
		_instance._balls.Clear();
	}

	public static int Score{
		get {
			return _instance._score;
		}

		set {
			_instance._score = value;
		}
	}

	public static void AddScore(int number) {
		_instance._score += number;
	}

	public static AddCollisionCount() {
		_instance._collisionCount += 1.0f / _instance._balls.Count;
	}

	public static ClearCollisionCOunt() {
		_instance._collisionCount = 0f;
	}
}
