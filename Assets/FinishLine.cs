using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	private void OnTriggerEnter(Collider other){
		GameObject.Find("Person").SendMessage("Finish");
	}
}
