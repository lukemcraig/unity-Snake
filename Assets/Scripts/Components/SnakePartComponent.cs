﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class SnakePartComponent : MonoBehaviour {

	public bool isPregnant = false;
	public SnakePartComponent childPart;
	public GameObject snakePrefab;
}