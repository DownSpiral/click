using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour {

	// Use this for initialization
	public float total_time = 10f;
	public float time_remaining;
	public bool timerActive = false;
	public Image bar;
	void Start () {
		bar.color = new Color(0,1,0,1);
	}

	public void StartTimer() {
		time_remaining = total_time;
		timerActive = true;
		bar.color = getCurrentColor();
	}

	private Color getCurrentColor() {
		float green = (time_remaining/(1f * total_time));	
		float red = 1f - green;	
		return new Color(red, green, 0, 1);
	}

	// Update is called once per frame
	void Update () {
		if (timerActive) {
			if (time_remaining > 0) {
				time_remaining -= Time.deltaTime;	
				bar.color = getCurrentColor();
			} else {
				bar.color = new Color(0,1,0,1);
				timerActive = false;
			}
		}
	}
}
