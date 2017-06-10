using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {

	void Start() {
		setCounterText();
	}
	public Text counterText;
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
	}
}
