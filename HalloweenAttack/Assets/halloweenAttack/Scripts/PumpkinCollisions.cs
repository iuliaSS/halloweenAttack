using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Se ocupa de coliziunile elementelor defensive cu inamicii si proiectilele acestora
 */
public class PumpkinCollisions : MonoBehaviour {

    /**
     * Viata curenta a acestui element
     */
    private int shootingLife;

	void Start(){
		shootingLife = 10;
	}

	void OnTriggerEnter(Collider collider) {
		if (tag != "Shooting" && collider.gameObject.tag == "Enemy") {
            EnemyLife enemyLife = collider.gameObject.GetComponent<EnemyLife>();
            ScoreScript.scoreValue += enemyLife.getPoints();
            Destroy(collider.gameObject);
        }

		if (collider.gameObject.tag == "Bullet") {
			if (tag == "Shooting") {
				shootingLife--;
				if (shootingLife == 0)
					Destroy (this.gameObject);
				
				Destroy(collider.gameObject);
			}
		}
	}
}
