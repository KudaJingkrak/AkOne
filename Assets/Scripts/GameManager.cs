using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
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

	public List<Ball> GetBalls() {
		return _instance._balls;
	}

	public Ball GetBall(int index) {
		if(index < 0 || index > _instance._balls.Count) {
			return null;
		}

		return _instance._balls[index];
	}

	public void AddBall(Ball ball) {
		_instance._balls.Add(ball);
	}

	public void RemoveBall(Ball ball) {
		_instance._balls.Remove(ball);
	}

	public void RemoveBall(int index) {
		if(index < 0 || index > _instance._balls.Count) {
			return;
		}

		_instance._balls.RemoveAt(index);
	}

	public void ClearBalls() {
		_instance._balls.Clear();
	}


}
