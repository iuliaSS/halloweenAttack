using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PumpkinManager : MonoBehaviour {
	
	[SerializeField]
	public GameObject p1Selection, p2Selection, p3Selection;
	public PumpkinSelection clickedSelection;
	float distance=10f;
    private string message = "You don't have enough money!";
    private int hasMoney;

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

    void OnGUI()
    {
        if (hasMoney == -1)
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 500f, 500f), message);
    }

    void PlacePumpkin(Vector3 position) {
        hasMoney = BuyPumpkin(clickedSelection.pumpkinPrefab);

        if (hasMoney == 0)
        {
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

            Hover.Instance.Deactivate();
        }
        clickedSelection = null;
    }

	public void PickPumpkin(PumpkinSelection selection) {
		this.clickedSelection = selection;
        Hover.Instance.Activate(selection.Sprite);
	}

    public int BuyPumpkin(GameObject pumpkin)
    {
        if (pumpkin.tag == "Rotating")
        {
            if (ScoreScript.scoreValue >= 15)
                ScoreScript.scoreValue -= 15;
            else
                return -1;
        }

        if (pumpkin.tag == "Shooting")
        {
            if (ScoreScript.scoreValue >= 10)
                ScoreScript.scoreValue -= 10;
            else
                return -1;
        }

        if (pumpkin.tag == "Exploding")
        {
            if (ScoreScript.scoreValue >= 5)
                ScoreScript.scoreValue -= 5;
            else
                return -1;
        }

        return 0;
    }
}
