using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible_controller : MonoBehaviour {
	[SerializeField]
	private float speed = 0.6f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		transform.Rotate(Vector3.up * speed, Space.World);
	//	transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}

}
