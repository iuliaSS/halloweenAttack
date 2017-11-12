using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingEnemies : MonoBehaviour {

	public GameObject prefab;
	public float time;

	// Use this for initialization
	IEnumerator Start () {
		float[] y;
		int random;
		y = new float[] {3.5f, 1.4f, -0.8f};
		yield return new WaitForSeconds (time);
	
		for (int i = 0; i < 10; i++)
		{
			yield return new WaitForSeconds (15);
			Instantiate(prefab);
			random = Random.Range(0, 3);
			prefab.transform.transform.position = new Vector3 (10, y[random], 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
