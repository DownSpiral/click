using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
	public static GameState state;

	void Start() {
		if (state == null) {
			state = this;
			GameObject.DontDestroyOnLoad(GameObject);
		} else {
			Destroy(GameObject);
			Debug.Log("Destroying duplicate GameState object");
		}
	}
	// Use this for initialization
	private int clickCount = 0;
	public int getClickCount() {
		return clickCount;
	}
	public void incClickCount() {
		clickCount += 1;
	}
	public void resetClickCount() {
		clickCount = 0;
	}
}
