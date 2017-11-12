using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Exploding" ||
			collider.gameObject.tag == "Shooting" ||
			collider.gameObject.tag == "Tombstone") {
			Destroy(collider.gameObject);
		}
	}
}
