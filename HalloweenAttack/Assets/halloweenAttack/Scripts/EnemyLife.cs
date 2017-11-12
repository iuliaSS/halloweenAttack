using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour {

	public int life;
    private int points;

    void Start(){
        points = life;
    }

    public int getPoints()
    {
        return points;
    }

    void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "BlueBullet") {

			life--;
            if (life == 0) {
                Destroy(this.gameObject);
                ScoreScript.scoreValue += points;
                Debug.Log(ScoreScript.scoreValue);
            }
			Destroy (collider.gameObject);
		}
	}
}
