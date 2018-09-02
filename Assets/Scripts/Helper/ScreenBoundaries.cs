using UnityEngine;

public class ScreenBoundaries {
	public static Vector2 CalcTopCorner(Vector3 position) {
		float camDistance = Vector3.Distance(position, Camera.main.transform.position);
		return Camera.main.ViewportToWorldPoint(new Vector3(1,1, camDistance));
	}

	public static Vector2 CalcBottomCorner(Vector3 position) {
		float camDistance = Vector3.Distance(position, Camera.main.transform.position);
		return Camera.main.ViewportToWorldPoint(new Vector3(0,0, camDistance));
	}
}
