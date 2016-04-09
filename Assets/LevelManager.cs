using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public Transform mainMenu, optionsMenu, controlMenu;
	
	public void LoadScene(string name){
		Application.LoadLevel(name);
	}
	public void QuitGame(){
		Application.Quit();
	}
	public void OptionsMenu(bool clicked){
		if (clicked == true) {
			optionsMenu.gameObject.SetActive(clicked);
			mainMenu.gameObject.SetActive(false);
		} else {
			optionsMenu.gameObject.SetActive(clicked);
			mainMenu.gameObject.SetActive(true);
		}
	}
	public void ControlMenu(bool clicked){
		if (clicked == true) {
			controlMenu.gameObject.SetActive(clicked);
			optionsMenu.gameObject.SetActive(false);
		} else {
			controlMenu.gameObject.SetActive(clicked);
			optionsMenu.gameObject.SetActive(true);
		}
	}
}
