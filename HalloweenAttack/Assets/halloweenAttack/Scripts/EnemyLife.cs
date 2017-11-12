using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour {

	public int life;

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "BlueBullet") {

			life--;
			if (life == 0)
				Destroy (this.gameObject);
			Destroy (collider.gameObject);
		}
	}
}
