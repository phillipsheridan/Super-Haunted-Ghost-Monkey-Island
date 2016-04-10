using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {



	private Transform target;
	private Transform self;
	public float moveSpeed = 3.0f;
	public float rotationSpeed = 3.0f;
	// Use this for initialization
	void Awake () {
		self = transform;


	
	}
	void Start () {
		target = GameObject.FindWithTag ("Player").transform;
	}
	// Update is called once per frame
	void Update () {
		self.rotation = Quaternion.Slerp (self.rotation, Quaternion.LookRotation (target.position - transform.position), rotationSpeed * Time.deltaTime);
		self.position += self.forward * moveSpeed * Time.deltaTime;
	
	}
}
