using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public float speed = 20f;

	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}
	


	void Update () {
		
	}
}
