﻿
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
  
    public static int scoreValue = 50;
    Text score;


	// Use this for initialization
	void Start () {
        score = GetComponent<Text> ();     
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Score: " + scoreValue;
		
	}
}
