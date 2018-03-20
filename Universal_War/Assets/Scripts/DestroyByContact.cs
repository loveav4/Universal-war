using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;

	public int scoreValue = 10;
	private GameController gameController;

	void Start(){
		GameObject controller = GameObject.FindWithTag ("GameController");

		if (null != controller) {
			gameController = controller.GetComponent<GameController> ();
		}

		if (null == gameController) {
			Debug.Log ("Cannot find 'GameController' script");
		}
			
	}

	void OnTriggerEnter(Collider other) {

		if (other.tag == "Boundary") {
			return;
		}

		Instantiate(explosion, transform.position, transform.rotation);

		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver ();
		}

		gameController.addScore (scoreValue);
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
}
