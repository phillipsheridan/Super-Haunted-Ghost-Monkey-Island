using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Water") {
			GameObject.Find ("Player").SendMessage ("Finish");
			print ("Done");
			Application.LoadLevel("MainMenu");

		}
	}
}
