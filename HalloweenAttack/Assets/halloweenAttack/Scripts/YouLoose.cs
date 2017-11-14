using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Gestioneaza actiunile in momentul pierderii
 */
public class YouLoose : MonoBehaviour {

	private string message = "You loose!";
	private int loose = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Tombstone") == null) {
			loose = -1;
			Time.timeScale = 0;
		}
	}

	void OnGUI()
	{
		if (loose == -1)
			GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 500f, 500f), message);
	}
}
