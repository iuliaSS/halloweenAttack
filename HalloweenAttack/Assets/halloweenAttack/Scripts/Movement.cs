using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	private float speed;

	// Use this for initialization
	void Start () {
		speed = -1f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
	}
}
