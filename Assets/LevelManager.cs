using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void loadLevel(string name) {
		Debug.Log("Loading level: " + name);
		if (name == "Quit") {
			Debug.Log("Quitting the Application");
			Application.Quit();
		} else {
			SceneManager.LoadScene(name);
		}
	}
}
