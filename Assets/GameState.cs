using UnityEngine;
using System.Collections;
using System.Linq;

public class GameState : MonoBehaviour {
	public static GameState state;

	void Awake() {
		if (state == null) {
			state = this;
			GameObject.DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
			Debug.Log("Destroying duplicate GameState object");
		}
	}
	private static int CPS_TIME_BINS = 20;
	private static float CPS_TIME_SPAN = 2.0f;
	void Start() {
		InvokeRepeating("calcRunningAverage", 0.0f, CPS_TIME_SPAN / CPS_TIME_BINS);
	}
	// Use this for initialization
	private int clickCount = 0;
	int[] clickCountBins = Enumerable.Repeat(0, CPS_TIME_BINS).ToArray();
	int currentBin = 0;
	float highestClicksPerSecond = 0.0f;
	public int getClickCount() {
		return clickCount;
	}
	public float getHighestClicksPerSecond() {
		return highestClicksPerSecond;
	}
	public void incClickCount() {
		clickCountBins[currentBin] += 1;
		clickCount += 1;
	}
	public void resetClickCount() {
		clickCount = 0;
		clickCountBins = Enumerable.Repeat(0, CPS_TIME_BINS).ToArray();
		highestClicksPerSecond = 0.0f;
	}
	public float getClicksPerSecond() {
		float cps = clickCountBins.Sum() / CPS_TIME_SPAN;
		if (cps > highestClicksPerSecond) {
			highestClicksPerSecond = cps;
		}
		return cps;
	}
	private void calcRunningAverage() {
		currentBin = (currentBin + 1) % clickCountBins.Length;
		clickCountBins[currentBin] = 0;
	}

}
