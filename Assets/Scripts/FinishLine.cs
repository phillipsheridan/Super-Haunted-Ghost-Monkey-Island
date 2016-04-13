using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	private void OnColliderEnter(Collider other){
		GameObject.Find("Player").SendMessage("Finish");
	}
}
