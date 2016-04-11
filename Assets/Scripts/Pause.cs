using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject pauseMenu;

	public bool isPaused;

	// Use this for initialization
	void Start () {
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isPaused) {
			PauseGame (true);
		} else {
			PauseGame (false);
		}

		if (Input.GetButtonDown("Cancel")) {
			SwitchPause();
		}
	}

	void PauseGame(bool state){
		if (state) {
			pauseMenu.SetActive(true);
			Time.timeScale = 0.0f; // paused
		} else {
			Time.timeScale = 1.0f; // unpaused
			pauseMenu.SetActive(false);
		}
		pauseMenu.SetActive(state);
	}

	public void SwitchPause(){
		if (isPaused) {
			isPaused = false; // change value
		} else{
			isPaused = true;
		}
	}

	public void MainMenuLoader(string name){
		Application.LoadLevel(name);
	}
}
