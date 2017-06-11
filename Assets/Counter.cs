using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {

	void Start() {
		setCounterText();
	}
	void Update() {
		clicksPerSecondText.text = string.Format("{0:N1}", GameState.state.getClicksPerSecond());
		highestClicksPerSecondText.text = string.Format("{0:N1}", GameState.state.getHighestClicksPerSecond());
	}
	public Text counterText;
	public Text clicksPerSecondText;
	public Text highestClicksPerSecondText;
	// Use this for initialization
	public void incrementCounter () {
		GameState.state.incClickCount();	
		setCounterText();
	}
	public void reset () {
		GameState.state.resetClickCount();	
		setCounterText();
	}
	public void setCounterText() {
		counterText.text = GameState.state.getClickCount().ToString();
		clicksPerSecondText.text = GameState.state.getClicksPerSecond().ToString("0.0");
	}
}
