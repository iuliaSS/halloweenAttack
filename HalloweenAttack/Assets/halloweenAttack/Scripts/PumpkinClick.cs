using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (bullet.time == 6)
        {
            bullet.time = 3;
        } else if (bullet.time == 3)
        {
            bullet.time = 1;
            //TODO: ERASE ALL MONEY
        }
    }
}
