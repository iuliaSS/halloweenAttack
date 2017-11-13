using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingEnemies : MonoBehaviour {
    
	public GameObject prefab;
	public float time;
    public int generatedEnemies;
    float[] y;

    // Use this for initialization
    IEnumerator Start () {
		int random;
		y = new float[] {2.8f, 0.8f, -1.3f};
		yield return new WaitForSeconds (time);
        
		for (int i = 0; i < 10; i++)
		{
			yield return new WaitForSeconds (15);
			GameObject instance = Instantiate(prefab);
			random = Random.Range(0, 3);
			prefab.transform.position = new Vector3 (5, y[random], -0.1f);
			Destroy(instance, 40);
		}
        LevelScript.levelValue = "2";
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(12);
            GameObject instance = Instantiate(prefab);
            random = Random.Range(0, 3);
            prefab.transform.position = new Vector3(5, y[random], -0.1f);
            Destroy(instance, 40);
        }

        LevelScript.levelValue = "3";
        for (int i = 0; i < 50; i++)
        {
            yield return new WaitForSeconds(6);
            GameObject instance = Instantiate(prefab);
            random = Random.Range(0, 3);
            prefab.transform.position = new Vector3(5, y[random], -0.1f);
            Destroy(instance, 40);
        }

        LevelScript.levelValue = "FINAL JOC";
    }

    // Update is called once per frame
    void Update () {
        
    }
}
