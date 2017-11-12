using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour {

	private MeshRenderer renderer;
	// Use this for initialization
	void Start () {
		gameObject.layer = 2;
	}
}
