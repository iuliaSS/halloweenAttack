using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Permite deplasarea dovleacului pana la amplasare
 */
public class Pumpkin {


    /**
     * Pozitie curenta
     */
    public Point GridPosition { get; set;}
	[SerializeField]
	public SpriteRenderer spriteRenderer;

	public Pumpkin(Point p) {
		this.GridPosition = p;
	}

	public void moveUp () {
		this.GridPosition = new Point(this.GridPosition.X, this.GridPosition.Y + 1);
	}

	public void moveDown () {
		this.GridPosition = new Point(this.GridPosition.X, this.GridPosition.Y - 1);
	}

	public void moveLeft () {
		this.GridPosition = new Point(this.GridPosition.X - 1, this.GridPosition.Y);
	}

	public void moveRight () {
		this.GridPosition = new Point(this.GridPosition.X + 1, this.GridPosition.Y);
	}
}
