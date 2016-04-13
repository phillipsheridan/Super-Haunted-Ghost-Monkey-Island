using UnityEngine;
using System.Collections;

public class MonkeyAttack : MonoBehaviour {
	
	private void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Monkey") {
			Application.LoadLevel ("MainMenu");

		}
	}
}
