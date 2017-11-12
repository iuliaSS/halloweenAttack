using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinCollisions : MonoBehaviour {
	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Enemy") {
			Destroy(collider.gameObject);
		}
	}
}
