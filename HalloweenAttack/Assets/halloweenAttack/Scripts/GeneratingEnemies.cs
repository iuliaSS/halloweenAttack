using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingEnemies : MonoBehaviour {

	public GameObject prefab;
	public float time;

	// Use this for initialization
	IEnumerator Start () {
		int[] y;
		int random;
		y = new int[] {-10, 0, 10};
		yield return new WaitForSeconds (time);
	
		for (int i = 0; i < 10; i++)
		{
			yield return new WaitForSeconds (15);
			Instantiate(prefab);
			random = Random.Range(0, 3);
			prefab.transform.transform.position = new Vector3 (0, y[random], 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
