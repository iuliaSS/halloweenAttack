using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Gestioneaza miscarea inamicilor
 */
public class Movement : MonoBehaviour {


    /**
     * Viteza cu care se deplaseaza inamicii
     */
    public float speed;

	// Use this for initialization
	void Start () {
        speed = -1f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
	}
}
