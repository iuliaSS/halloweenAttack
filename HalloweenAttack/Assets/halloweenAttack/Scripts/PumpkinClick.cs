using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Se ocupa de upgradarea elementului defensiv
 */
public class PumpkinClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Bullet bullet = gameObject.GetComponent<Bullet>() as Bullet;
		if (bullet.time == 3)
		{
			if (ScoreScript.scoreValue >= 20) {
				bullet.time = 1;
				ScoreScript.scoreValue = 0;
			} else
				PumpkinManager.hasMoney = -1;
		}

        if (bullet.time == 6)
        {
			if (ScoreScript.scoreValue >= 15) {
				bullet.time = 3;
				ScoreScript.scoreValue -= 15;
			} else
				PumpkinManager.hasMoney = -1;
        } 
    }
}
