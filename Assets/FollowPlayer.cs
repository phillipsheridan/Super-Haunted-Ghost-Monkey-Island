using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {



	public Transform Player;
	public float speed;
	public bool followingPlayer;
	// Use this for initialization
	void Start () {
		this.followingPlayer = true;


	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (followingPlayer) {
			transform.position = Vector3.MoveTowards (transform.position, Player.position, speed);

		}
	
	}
}
