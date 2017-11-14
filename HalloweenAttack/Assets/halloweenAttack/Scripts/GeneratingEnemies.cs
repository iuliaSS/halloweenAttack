using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * Genereaza inamici in functie de nivel
 * 
 */
public class GeneratingEnemies : MonoBehaviour {
    
    /**
     * tipul de inamic
     */
	public GameObject prefab;

    /**
    * timpul dupa care se genereaza
    */
    public float time;

   /**
   * vector de pozitii 
   */
    float[] y;

    // Use this for initialization
    IEnumerator Start () {
		int random;
		y = new float[] {2.8f, 0.8f, -1.3f};
		yield return new WaitForSeconds (time);
        
		for (int i = 0; i < 3; i++)
		{
			yield return new WaitForSeconds (15);
			GameObject instance = Instantiate(prefab);
			random = Random.Range(0, 3);
			prefab.transform.position = new Vector3 (5, y[random], -0.1f);
			Destroy(instance, 40);
		}

        LevelScript.levelValue = "2";
        for (int i = 0; i < 7; i++)
        {
            yield return new WaitForSeconds(7.5f);
            GameObject instance = Instantiate(prefab);
            random = Random.Range(0, 3);
            prefab.transform.position = new Vector3(5, y[random], -0.1f);
            Destroy(instance, 40);
        }

        LevelScript.levelValue = "3";
        for (int i = 0; i < 17; i++)
        {
            yield return new WaitForSeconds(3.75f);
            GameObject instance = Instantiate(prefab);
            random = Random.Range(0, 3);
            prefab.transform.position = new Vector3(5, y[random], -0.1f);
            Destroy(instance, 40);
        }

        LevelScript.levelValue = "FINAL JOC";
        while (true)
        {
            yield return new WaitForSeconds(1.875f);
            GameObject instance = Instantiate(prefab);
            random = Random.Range(0, 3);
            prefab.transform.position = new Vector3(5, y[random], -0.1f);
            Destroy(instance, 40);
        }
    }

    // Update is called once per frame
    void Update () {
        
    }
}
