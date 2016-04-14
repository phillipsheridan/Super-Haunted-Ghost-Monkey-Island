using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class FollowPlayer : MonoBehaviour {



	private Transform target;
	private Transform self;
	public float moveSpeed = 3.0f;
	public float rotationSpeed = 3.0f;
	public AudioSource source;
	// Use this for initialization
	void Awake () {
		self = transform;


	
	}
	void Start () {
		target = GameObject.FindWithTag ("Player").transform;
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (target.gameObject.transform.position.y <= 1.3) { 
			source.PlayDelayed(3);
			self.rotation = Quaternion.Slerp (self.rotation, Quaternion.LookRotation (target.position - self.position), rotationSpeed * Time.deltaTime);
			self.position += self.forward * moveSpeed * Time.deltaTime;

		} 

	}
}
