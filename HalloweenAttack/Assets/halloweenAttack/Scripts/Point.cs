using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Retine coordonatele de pe harta si permite operatii primitive cu acestea
 */
public struct Point {


    /**
     *  Coordonata X
     */
    public int X { get; set; }

    /**
     * Coordonata Y
     */
    public int Y { get; set; }

	public Point(int x, int y) {
		this.X = x;
		this.Y = y;
	}

	public static bool operator == (Point p1, Point p2) {
		return p1.X == p2.X && p1.Y == p2.Y;
	}

	public static bool operator != (Point p1, Point p2) {
		return p1.X != p2.X || p1.Y != p2.Y;
	}
}
