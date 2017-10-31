﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Point {
	public int X { get; set; }
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
