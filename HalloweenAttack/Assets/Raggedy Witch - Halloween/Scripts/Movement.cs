using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;
	public float xaxis;

	// Use this for initialization
	void Start () {
		speed = -0.03f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed, 0f, 0f);
	}
}
