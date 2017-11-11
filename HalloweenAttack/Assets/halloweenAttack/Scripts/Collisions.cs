using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Defensive") {
			Destroy(collider.gameObject);
		}
	}
}
