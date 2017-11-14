using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Controleaza miscarea dovleacului dupa mouse pana la plasarea pe harta
 */
public class Hover : Singleton<Hover> {

    public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        FollowMouse();
	}

    private void FollowMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));
        targetPosition.z = -0.1f;
        transform.position = targetPosition;
        transform.localScale = new Vector3(0.15f, 0.15f);
    }

    public void Activate(Sprite sprite)
    {
        this.spriteRenderer.sprite = sprite;
        this.spriteRenderer.enabled = true;
    }

    public void Deactivate()
    {
        this.spriteRenderer.enabled = false;
    }
}
