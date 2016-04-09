using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text TimerText;
	private float startTime;
	private bool finish = false;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (finish) {
			return;
		}
		float t = Time.time - startTime;

		string minutes = ((int) t / 60).ToString();
		string seconds = (t % 60).ToString("f2"); // f2 means only two decimals

		TimerText.text = minutes + ":" + seconds;
	}

	public void Finish(){
		finish = true;
		TimerText.color = Color.green;
	}
}
