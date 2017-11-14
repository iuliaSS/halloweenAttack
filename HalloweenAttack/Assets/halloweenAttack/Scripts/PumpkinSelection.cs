using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Gestioneaza dovleacul selectat
 */
public class PumpkinSelection : MonoBehaviour {
	[SerializeField]
	public GameObject pumpkinPrefab;
    [SerializeField]
    private Sprite sprite;

    public Sprite Sprite
    {
        get
        {
            return sprite;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
