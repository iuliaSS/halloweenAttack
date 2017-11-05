using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinManager : MonoBehaviour {
	[SerializeField]
	public GameObject prefab;
	public Pumpkin p;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			p = new Pumpkin (new Point ((int)Input.mousePosition.x, (int)Input.mousePosition.y));
			prefab.transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
			Instantiate (prefab, prefab.transform.position, Quaternion.identity);
		}
	}

	void OnMouseDown() {
		
	}
}
