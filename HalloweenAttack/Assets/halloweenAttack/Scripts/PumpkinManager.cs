using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PumpkinManager : MonoBehaviour {
	
	[SerializeField]
	public GameObject p1Selection, p2Selection, p3Selection;

	public PumpkinSelection clickedSelection;
	float distance=10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!EventSystem.current.IsPointerOverGameObject () && clickedSelection != null) {
			if (Input.GetMouseButtonDown (0)) {
				Vector3 mousePosition = Input.mousePosition;
				Vector3 targetPosition = Camera.main.ScreenToWorldPoint (new Vector3 (mousePosition.x, mousePosition.y, distance));
				PlacePumpkin (targetPosition);
			}
		}
	}

	private void OnMouseOver() {
		Debug.Log ("asaca");
	}

	void PlacePumpkin(Vector3 position) {
		GameObject pumpkin = Instantiate (clickedSelection.pumpkinPrefab, position, Quaternion.identity);
		if (pumpkin.tag == "Rotating")
		{
			Rotate rotate = pumpkin.AddComponent<Rotate> () as Rotate;
			Destroy(pumpkin, 10.0f);
		}
		if (pumpkin.tag == "Shooting")
		{
			Bullet bullet = pumpkin.AddComponent<Bullet> () as Bullet;
            pumpkin.AddComponent<PumpkinClick>();
			bullet.bulletPrefab = Resources.Load("HealthFullBlue") as GameObject;
			bullet.speed = -5;
			bullet.time = 6;
		}
		BuyPumpkin ();			
	}

	public void PickPumpkin(PumpkinSelection selection) {
		this.clickedSelection = selection;
	}

	public void BuyPumpkin() {
		clickedSelection = null;
	}
}
